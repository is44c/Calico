#
# Calico - Scripting Environment
#
# Copyright (c) 2011, Doug Blank <dblank@cs.brynmawr.edu>
#
# This program is free software: you can redistribute it and/or modify
# it under the terms of the GNU General Public License as published by
# the Free Software Foundation, either version 3 of the License, or
# (at your option) any later version.
#
# This program is distributed in the hope that it will be useful,
# but WITHOUT ANY WARRANTY; without even the implied warranty of
# MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
# GNU General Public License for more details.
#
# You should have received a copy of the GNU General Public License
# along with this program.  If not, see <http://www.gnu.org/licenses/>.
#
# $Id: $

from __future__ import print_function
import clr
clr.AddReference("FSharpShell.dll")

import FSharpShell
import System

import traceback
import os

from engine import Engine
from utils import Language, ConsoleStream

class FSharpEngine(Engine):
    def __init__(self, manager):
        super(FSharpEngine, self).__init__(manager, "fsharp")
        # FIXME: set console outputs and errors for Evaluate
        self.engine = FSharpShell()
        for assembly in System.AppDomain.CurrentDomain.GetAssemblies():
            try:
                self.engine.ReferenceAssembly(assembly)
            except:
                #print "FSharp: unable to load assembly '%s'" % assembly
                pass
        # FIXME: make calico available in some manner
        #self.engine.Evaluate("calico", manager.calico)

    def execute(self, text):
        try:
            self.engine.Evaluate(text)
        except:
            traceback.print_exc()

    def execute_file(self, filename):
        self.stdout.write("Run filename '%s'!\n" % filename)
        self.engine.Evaluate("#load \"%s\";;" % filename)

    def ready_for_execute(self, text):
        """
        Return True if expression parses ok.
        """
        lines = text.split("\n")
        if lines[-1].strip() == "":
            return True
        elif lines[-1].startswith(" "):
            return False
        elif not lines[-1].rstrip().endswith(";;"):
            return False
        return True

    def stop(self):
        self.engine.Close()

class FSharpLanguage(Language):
    def get_engine_class(self):
        return FSharpEngine

def register_language():
    return FSharpLanguage("fsharp", ["fs"])
