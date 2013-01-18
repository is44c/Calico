# This file was constructed automatically by the Calico Project
# See http://calicoproject.org/ for more details.

import sys
import os
import clr                 # Allows connection to CLR/DLR bits
clr.AddReference("Calico") # Add reference to the main Calico.exe
# Add the DLLs from the lib dir:
import glob
libpath = os.path.abspath(os.path.join(os.path.dirname(__file__), "lib"))
sys.path.append(libpath)
#print(sys.path)
for filename in glob.glob(os.path.join(libpath, "*.dll")):
    filename = os.path.abspath(filename)
    #print(filename)
    clr.AddReference(filename)
import edu
import System
import Calico
import traceback

def isNone(v):
    return hasattr(v, "isNone") and v.isNone()

# Now, define the Document, Engine, and Language classes:
class MyLanguageEngine(Calico.Engine):
    def PostSetup(self, calico):
        """
        Do things here that you want to do once (initializations).
        """
        try:
            self.options = edu.rice.cs.dynamicjava.Options.DEFAULT
            self.classPathManager = edu.rice.cs.drjava.model.repl.newjvm.ClassPathManager(
                edu.rice.cs.plt.reflect.ReflectUtil.SYSTEM_CLASS_PATH)
            self.interpreter = edu.rice.cs.dynamicjava.interpreter.Interpreter(self.options)
                #self.classPathManager.makeClassLoader(None))
        except:
            traceback.print_exc()
            
    def Execute(self, text, feedback=True):
        """
        This is where you do something for the text (code). This is
        the interpreter.
        """
        try:
            retval = self.interpreter.interpret(text)
            try:
                retval = retval.unwrap()
            except:
                pass
            if not isNone(retval) and feedback:
                print(retval.toString())
        except Exception, error:
            print(error.message.replace("koala.dynamicjava.interpreter.error.", ""))
        return True

    def ExecuteFile(self, filename):
        """
        This is the code that will interprete a file.
        """
        print("Run filename '%s'!" % filename)
        try:
            text = "".join(open(filename).readlines())
        except:
            traceback.print_exc()
            return

        self.Execute(text, false)
        return True

    def ReadyToExecute(self, text):
        """
        Return True if expression parses ok and you are ready
        to execute. If you return False, then the user can still
        interactively type text into the Calico Shell.
        """
        return text.split("\n")[-1].strip() == ""

class MyLanguage(Calico.Language):
    """
    The Language class holds the Document and the Engine classes, and
    the languages properties.
    """
    def __init__(self):
        self.name = "java"
        self.proper_name = "Java"
        self.extensions = System.Array[str](["java"])
        self.mimetype = "text/x-java"
        self.LineComment = "//"

    def MakeEngine(self, manager):
        """
        Make and hold the language singleton.
        """
        self.engine = MyLanguageEngine(manager)

    def GetUseLibraryString(self, fullname):
        """
        Given a path to a a library DLL, return the string to add to
        script.
        """
        path, filename = os.path.split(fullname)
        return "import " + filename

    def getExamplesPath(self, root_path):
        """
        Given the root_path to calico, return the path to the examples
        folder.
        """
        return os.path.join(os.path.dirname(__file__), "examples")

# And finally define a method of loading it:
def MakeLanguage():
    """
    Make an instance of the Language, and return it. Usually you do this
    just once, even for non-visible languages.
    """
    return MyLanguage()


## engine = MyLanguageEngine(calico.manager)
## engine.PostSetup(calico)
## engine.Execute("1 + 1;", True)