# Setup environment:
import sys, os
sys.path.append(os.path.abspath("modules"))

# Bring in DLLs to import from:
import clr
clr.AddReference("gtk-sharp")
clr.AddReference("pango-sharp")
clr.AddReference("IronPython.dll")
clr.AddReference("IronPython.Modules.dll")
clr.AddReference("IronRuby.dll")
clr.AddReference("IronRuby.Libraries.dll")
clr.AddReference("Microsoft.Scripting")
clr.AddReference("glib-sharp")

clr.AddReference("PJScheme.dll")

# Bring .NET References into IronPython scope:
import Gtk
import GLib

# Import pure-Python modules:
import traceback

# Setup Runtime environment:
def handle_exception(e):
    print e.__class__.__name__

# Turn on Unhandled Exception Handled:
#GLib.ExceptionManager.UnhandledException += handle_exception

# Define local functions and classes
from utils import _

class PyjamaProject(object):
    def __init__(self, argv):
        self.shell = None
        self.editor = None
        request_shell = False
        request_editor = False
        files = []
        for arg in argv:
            if arg == "--shell":
                request_shell = True
            elif arg == "--editor":
                request_editor = True
            else:
                files.append(arg)
                request_editor = True
        if files == [] and not request_editor:
            request_shell = True
        if request_editor:
            from editor import EditorWindow
            self.editor = EditorWindow(self, files)
        if request_shell:
            from shell import ShellWindow
            self.shell = ShellWindow(self)

    def on_run(self, obj, event):
        doc = self.get_current_doc()
        if doc and doc.textview.HasFocus:
            text = str(doc.textview.Buffer.Text)
            doc.execute(text, "Loading file...")
        else:
            self.command_pane.textview.HasFocus = True
            text = str(self.command_pane.textview.Buffer.Text)
            doc.execute(text)

    def on_close(self, what):
        if what == "shell":
            if self.shell:
                self.shell.window.Hide()
        elif what == "editor":
            if self.editor:
                self.editor.window.Hide()
        if (((self.editor.window is None) or 
             (not self.editor.window.Visible)) and 
            ((self.shell is None) or 
             (not self.shell.window.Visible))):
            Gtk.Application.Quit()

    def setup_shell(self, *args, **kwargs):
        if self.shell is None:
            from shell import ShellWindow
            self.shell = ShellWindow(self)
        else:
            self.shell.window.Show()

    def setup_editor(self, *args, **kwargs):
        if self.editor is None:
            from editor import EditorWindow
            self.editor = EditorWindow(self)
        else:
            self.editor.window.Show()

# Let's start!
Gtk.Application.Init()
#------------------------------
try:
    pw = PyjamaProject(sys.argv[1:])
except:
    traceback.print_exc()
    sys.exit()
#------------------------------
Gtk.Application.Run()
