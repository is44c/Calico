//
//  Main.cs
//  
//  Author:
//       Douglas S. Blank <dblank@cs.brynmawr.edu>
// 
//  Copyright (c) 2011-2013 The Calico Project
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using Gtk;
using System.Collections.Generic; // IList
using Mono.Unix;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace Calico {
    class MainClass {
        public static string Version = "2.3.7";
        public static bool IsLoadLanguages = true;
        public static bool verbose = false;

       /*
       private static bool IsApplicationRunningOnMono(string processName)
       {
           var processFound = 0;

           Process[] monoProcesses;
           ProcessModuleCollection processModuleCollection;

           //find all processes called 'mono', that's necessary because our app runs under the mono process!
           monoProcesses = Process.GetProcessesByName("mono");

           for (var i = 0; i <= monoProcesses.GetUpperBound(0); ++i)
           {
               processModuleCollection = monoProcesses[i].Modules;

               for (var j = 0; j < processModuleCollection.Count; ++j)
               {
                   if (processModuleCollection[j].FileName.EndsWith(processName))
                   {
                       processFound++;
                   }
               }
           }

           //we don't find the current process, but if there is already another one running, return true!
           return (processFound == 1);
       }
       */
        [STAThread]
        public static void Main(string[] args) {
            System.Console.WriteLine(_("Loading Calico version {0}..."), Version);
            if (((IList<string>)args).Contains("--verbose")) {
                verbose = true;
            }
            // Setup config
            string config_path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            if (verbose) {
                System.Console.WriteLine(_("    looking for config in \"{0}\"..."), config_path);
            }
            config_path = System.IO.Path.Combine(config_path, "calico", "config.xml");
            Config config;
            if (((IList<string>)args).Contains("--reset")) {
                config = new Config(config_path, true);
            } else {
                config = new Config(config_path);
            }
            // Setup translations:
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(5);
            if (path.StartsWith("\\")) {
                path = path.Substring(1);
            }
            Catalog.Init("calico", System.IO.Path.Combine(path, "..", "locale"));
            
            // Process non executing flags which stop quickly:
            if (((IList<string>)args).Contains("--help")) {
                Usage();
                System.Environment.Exit(0);
            } else if (((IList<string>)args).Contains("--version")) {
                Print("Calico Project, version {0} on {1}", Version, System.Environment.OSVersion.VersionString);
                Print("  " + _("Using Mono runtime version {0}"), MonoRuntimeVersion);
                System.Environment.Exit(0);
            }
            // The rest of this involves executing files of some kind:
            Dictionary<string, Language> languages = new Dictionary<string, Language>();
            // for language in directory, load languages:
            if (verbose) {
                System.Console.WriteLine(_("    Looking for languages in \"{0}\"..."), 
                                     System.IO.Path.Combine(path, "..", "languages"));
            }
            DirectoryInfo dir = new DirectoryInfo(System.IO.Path.Combine(path, "..", "languages"));
            if (IsLoadLanguages) {
                foreach (DirectoryInfo d in dir.GetDirectories("*")) {
                    foreach (FileInfo f in d.GetFiles("Calico*.dll")) {
			if (verbose) {
                            Print("        Loading {0}...", f.FullName);
                        }
                        Assembly assembly = Assembly.LoadFrom(f.FullName);
                        if (assembly != null) {
                            foreach (Type type in assembly.GetTypes()) {
                                MethodInfo method;
                                try {
                                    method = type.GetMethod("MakeLanguage");
                                } catch (Exception e) {
                                    Print("Failure; skipping language file '{0}': {1}", f.Name, e.Message);
                                    continue;
                                }
                                if (method != null) {
                                    Language language = null;
                                    try {
                                        language = (Language)method.Invoke(type, new object[]{});
                                    } catch (Exception e) {
                                        Print("Failure; skipping old language file '{0}': {1}", f.Name, e.Message);
                                        continue;
                                    }
                                    languages [language.name] = language;
                                    //Print("Registering language...'{0}'", language.name);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            //  Or load directly:
            //languages["python"] = CalicoPython.CalicoPythonLanguage.MakeLanguage();
            //languages["ruby"] = CalicoRubyLanguage.MakeLanguage();
            // Now, let's load engines
            Calico.LanguageManager manager = new Calico.LanguageManager((IList<string>)config.GetValue("config", "visible-languages"), path, languages);
            // Load Calico languages that depend on other Calico languages:
            foreach (DirectoryInfo d in dir.GetDirectories("*")) {
                foreach (FileInfo f in d.GetFiles("Calico*.py")) { // FIXME: allow other languages
                    System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(f.Name, @"Calico(.*)\.(.*)");
		    if (verbose) {
                        Print("        Loading {0}...", f.FullName);
                    }
                    //Print("Loading {0}...", f.FullName);
                    string def_language = match.Groups [2].ToString().ToLower();
                    if (def_language == "dll" || 
                        def_language == "cs" || 
                        def_language == "exe" || 
                        def_language.EndsWith("~") || 
                        def_language == "mdb") {
                        continue;
                    }
                    //Console.WriteLine(def_language); FIXME: need general interface for the following:
                    // GetVariable, extend classes, call a method from C#
                    try {
                        Calico.DLREngine engine = ((Calico.DLREngine)languages ["python"].engine);
                        var scope = engine.engine.ExecuteFile(f.FullName);
                        Func<object> method = scope.GetVariable<Func<object>>("MakeLanguage");
                        Language language = (Language)method();
                        languages [language.name] = language;
                        bool visible = ((IList<string>)config.GetValue("config", "visible-languages")).Contains(language.name);
                        manager.Register(language, visible); // This may fail, which won't add language
                        if (language.engine != null) {
                            language.engine.Setup(path);
                            language.engine.Start(path);
                        }
                    } catch (Exception e) {
                        Print("Failure; skipping language file '{0}': {1}", f.Name, e.Message);
                    }
                }
            }
            string local_lang_path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            local_lang_path = System.IO.Path.Combine(local_lang_path, "calico", "languages");
            if (verbose) {
                System.Console.WriteLine(_("    Looking for local languages in \"{0}\"..."), local_lang_path);
            }
            dir = new DirectoryInfo(local_lang_path);
            if (dir.Exists) {
                foreach (DirectoryInfo d in dir.GetDirectories("*")) {
                    foreach (FileInfo f in d.GetFiles("Calico*.py")) { // FIXME: allow other languages
                        System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(f.Name, @"Calico(.*)\.(.*)");
			if (verbose) {
                            Print("        Loading {0}...", f.FullName);
                        }
                        string def_language = match.Groups [2].ToString().ToLower();
                        if (def_language == "dll" || 
                            def_language == "cs" || 
                            def_language == "exe" || 
                            def_language.EndsWith("~") || 
                            def_language == "mdb") {
                            continue;
                        }
                        //Console.WriteLine(def_language); FIXME: need general interface for the following:
                        // GetVariable, extend classes, call a method from C#
                        try {
                            Calico.DLREngine engine = ((Calico.DLREngine)languages ["python"].engine);
                            var scope = engine.engine.ExecuteFile(f.FullName);
                            Func<object> method = scope.GetVariable<Func<object>>("MakeLanguage");
                            Language language = (Language)method();
                            languages [language.name] = language;
                            bool visible = ((IList<string>)config.GetValue("config", "visible-languages")).Contains(language.name);
                            manager.Register(language, visible); // This may fail, which won't add language
                            if (language.engine != null) {
                                language.engine.Setup(path);
                                language.engine.Start(path);
                            }
                        } catch (Exception e) {
                            Print("Failure; skipping local language file '{0}': {1}", f.Name, e.Message);
                        }
                    }
                }
            }
            // If a language isn't in the manager, it doesn't exist; remove it
            List<string> vlangs = new List<string>();
            foreach (string lang in ((IList<string>)config.GetValue("config", "visible-languages"))) {
                if (manager.languages.ContainsKey(lang)) {
                    vlangs.Add(lang);
                }
            }
            foreach (string lang in manager.getLanguages()) {
                Language language = manager [lang];
                language.InitializeConfig();
                language.LoadConfig(config);
            }
            config.SetValue("config", "visible-languages", vlangs);
            // End of loading languages
            // -------------------------------------------

            // Handle interrupt:
            MainWindow win = null;
            // Global settings:
            bool Debug = false;
            if (((IList<string>)args).Contains("--debug")) {
                Debug = true;
            }
            bool withGraphics = true;
            if (((IList<string>)args).Contains("--nographics")) {
                withGraphics = false;
            }
            // Process executable commands here:
            if (((IList<string>)args).Contains("--exec")) {
                if (withGraphics) {
                    Application.Init();
                    win = new CalicoConsole(args, manager, Debug, config, false);
                    Application.Run();
                } else {
                    win = new CalicoConsoleNoGUI(args, manager, Debug, config, false); 
                }
            } else if (((IList<string>)args).Contains("--repl")) {
                if (withGraphics) {
                    Application.Init();
                    win = new CalicoConsole(args, manager, Debug, config, true);  
                    Application.Run();
                } else {
                    win = new CalicoConsoleNoGUI(args, manager, Debug, config, true);
                }
            } else {
                // Catch SIGINT
                System.Threading.Thread  signal_thread = null;
                if (!System.Environment.OSVersion.Platform.ToString().Contains("Win")) {
                            UnixSignal[] signals = new UnixSignal [] {
                                new UnixSignal (Mono.Unix.Native.Signum.SIGINT),
                            };
                            signal_thread = new System.Threading.Thread (delegate () {
                                    // Wait for a signal to be delivered
                                    UnixSignal.WaitAny (signals, -1);
                                    Gtk.Application.Invoke( delegate { 
                                            if (win != null)
                                                win.RequestQuit(); 
                                        });
                                });
                            signal_thread.Start();
                }
                // Ok, we are going to run this thing!
                // If Gui, let's go:
                Application.Init();
                win = new MainWindow(args, manager, Debug, config, signal_thread);
                win.Show();
                Application.Run();
            }
        }

        public static void Print(string message, params object[] args) {
            Console.WriteLine(String.Format(message, args));
        }

        public static string _(string message) {
            return global::Mono.Unix.Catalog.GetString(message);
        }

        public static string MonoRuntimeVersion {
            get {
                Type mtype = System.Type.GetType("Mono.Runtime");
                System.Reflection.MethodInfo method = mtype.GetMethod("GetDisplayName", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
                return (string)method.Invoke(null, null);
            }
        }

        public static void Usage() {
            Print("");
            Print(_("Calico Project, version {0} on {1}"), Version, System.Environment.OSVersion.VersionString);
            Print("  " + _("Using Mono runtime version {0}"), MonoRuntimeVersion);
            Print("----------------------------------------------------------------------------");
            Print(_("Start calico with the following options:"));
            Print(_("  StartCalico                               Defaults to shell"));
            Print(_("  StartCalico FILENAME:LINE ...             Edits FILENAMEs, positioned on LINEs"));
            Print(_("  StartCalico --lang=LANGUAGE               Sets default language (python, etc.)"));
            Print(_("  StartCalico --chat                        Brings up chat window"));
            Print(_("  StartCalico --exec FILENAMEs              Run FILENAMEs standalone with graphics"));
            Print(_("  StartCalico --repl FILENAMEs              Run FILENAMEs standalone with graphics and then start read-eval loop"));
            Print(_("  StartCalico --exec --nographics FILENAMEs Run FILENAMEs standalone without graphics"));
            Print(_("  StartCalico --repl --nographics FILENAMEs Run FILENAMEs standalone without graphics and then start read-eval loop"));
	    Print(_("  StartCalico --nomodules                   Does not load the libraries from Calico/modules/*.dll"));
            Print(_("  StartCalico --version                     Displays the version number ({0})"), Version);
            Print(_("  StartCalico --verbose                     Displays detailed information, useful for debugging Calico"));
            Print(_("  StartCalico --debug                       Calico output goes to console rather than GUI"));
            Print(_("  StartCalico --reset                       Resets config settings to factory defaults"));
            Print(_("  StartCalico --help                        Displays this message"));
            Print("");
        }
    }
}
