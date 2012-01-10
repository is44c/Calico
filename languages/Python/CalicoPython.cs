//
//  CalicoPython.cs
//  
//  Author:
//       Douglas S. Blank <dblank@cs.brynmawr.edu>
// 
//  Copyright (c) 2011 The Calico Project
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
using System.Collections.Generic;
using System.IO;
using Calico;

namespace CalicoPython {

	public class CalicoPythonEngine : DLREngine {
	
	    public CalicoPythonEngine(LanguageManager manager) : base(manager) {
	        dlr_name = "py";
	        scriptRuntimeSetup = new Microsoft.Scripting.Hosting.ScriptRuntimeSetup();
	        languageSetup = IronPython.Hosting.Python.CreateLanguageSetup(null);
	        // Set LanguageSetup options here:
	        languageSetup.Options["FullFrames"] = true; // for debugging
	        scriptRuntimeSetup.LanguageSetups.Add(languageSetup); // add to local
	        // Create a Python-only scope:
			scriptRuntime = new Microsoft.Scripting.Hosting.ScriptRuntime(scriptRuntimeSetup);
	        scope = scriptRuntime.CreateScope();
	    }
	
	    public override void Start() {
	        // Get engine from manager:
			if (manager != null) {
	        	engine = manager.scriptRuntime.GetEngine(dlr_name);  
		    } else {
				engine = scriptRuntime.GetEngine(dlr_name);  
			}
	        // Set the compiler options here:
	        compiler_options = engine.GetCompilerOptions();
	        IronPython.Compiler.PythonCompilerOptions options = (IronPython.Compiler.PythonCompilerOptions)compiler_options;
	        options.PrintFunction = true;
	        options.AllowWithStatement = true;
	        options.TrueDivision = true;
			// FIXME: before a executefile, __name__ is "__builtin__";
			//        after it is "<module>"
			// FIXME: this doesn't work:
			//options.ModuleName = "__main__";
            //options.Module |= IronPython.Runtime.ModuleOptions.Initialize;
			// Set paths:
			ICollection<string> paths = engine.GetSearchPaths();
	        // Let users find Calico modules:
	        foreach (string folder in new string[] { "modules", "src" }) {
		  		paths.Add(Path.GetFullPath(folder));
	        }
	        engine.SetSearchPaths(paths);
	    }
		
		public IronPython.Runtime.Exceptions.TracebackDelegate OnTraceBack(
				  IronPython.Runtime.Exceptions.TraceBackFrame frame, 
				  string ttype, object retval) {
		  Calico.MainWindow.Invoke( delegate {
		      if (calico.CurrentDocument != null && calico.CurrentDocument.filename == frame.f_code.co_filename)
			  	calico.CurrentDocument.GotoLine((int)frame.f_lineno);
		      calico.UpdateLocal(frame);
		    });
		  if (calico.ProgramSpeed.Value == 0) {
		    calico.playResetEvent.WaitOne();
		    if (calico.ProgramSpeed.Value == 0) {
		      calico.playResetEvent.Reset();
		    }
		  } else {
		    int pause = (int)((100 - calico.ProgramSpeed.Value)/100.0 * 1000);
		    // Force at least a slight sleep, else no GUI controls
		    System.Threading.Thread.Sleep(Math.Max(pause, 1));
		  }
		  return OnTraceBack;
		}
		
		public override object GetDefaultContext() {
	        return IronPython.Runtime.DefaultContext.Default;
		}
		
		public override void ConfigureTrace() {
		   if (trace)
	            IronPython.Hosting.Python.SetTrace(engine, OnTraceBack);
		}
	}


	public class CalicoPythonDocument : TextDocument {

	    public CalicoPythonDocument(MainWindow calico, string filename, string language, string mimetype) :
            	   base(calico, filename, language, mimetype) {
            }

	    public override void UseLibrary(string fullname) {
                Mono.TextEditor.TextEditorData data = texteditor.GetTextEditorData();
                data.Document.BeginAtomicUndo();
                data.Document.EndAtomicUndo();
		string bname = System.IO.Path.GetFileNameWithoutExtension(fullname);
                texteditor.Insert(0, String.Format("import {0}\n", bname));
                data.Document.RequestUpdate(new Mono.TextEditor.LineUpdate(0));
                data.Document.CommitDocumentUpdate();
            }
        }
	
	public class CalicoPythonLanguage : Language {
		public CalicoPythonLanguage() : 
			base("python",  "Python", new string[] { "py", "pyw" }, "text/x-python") {
	    }
		
  	    public override void MakeEngine(LanguageManager manager) {
	        engine = new CalicoPythonEngine(manager);
	    }

            public override Document MakeDocument(MainWindow calico, string filename) {
            	return new CalicoPythonDocument(calico, filename, name, mimetype);
            }

	    public static new Language MakeLanguage() {
	        return new CalicoPythonLanguage();
	    }
	}
}
