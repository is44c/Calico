/*
Pyjama - Scripting Environment

Copyright (c) 2011, Doug Blank <dblank@cs.brynmawr.edu>

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.

$Id: $
*/
using System;
using IronPython.Hosting;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using Mono.Unix;

public class Pyjama {
  static void Main(string[] args) {
  	Catalog.Init("pyjama","./locale");
	ScriptRuntimeSetup scriptRuntimeSetup = new ScriptRuntimeSetup();
        LanguageSetup language = Python.CreateLanguageSetup(null);
        language.Options["FullFrames"] = true;
	scriptRuntimeSetup.LanguageSetups.Add(language);
	ScriptRuntime runtime = new Microsoft.Scripting.Hosting.ScriptRuntime(scriptRuntimeSetup);
	ScriptScope scope = runtime.CreateScope();
	ScriptEngine engine = runtime.GetEngine("python");
	ScriptSource source = engine.CreateScriptSourceFromFile("src/pyjama.py");
	source.Compile();
	try {
	  source.Execute(scope);
	} catch (IronPython.Runtime.Exceptions.SystemExitException e) {
	  // Nothing to do but exit
	}
  }
}