# Bring .NET References into IronPython scope:
import Gtk, Pango
import System

from window import Window
from engine import EngineManager, RubyEngine, PythonEngine, SchemeEngine
from utils import _, CustomStream

import traceback
import sys, os

class History(object):
    def __init__(self):
        self.history = []
        self.position = None

    def up(self):
        #print "up", self.position, self.history
        if self.position is not None and 0 <= self.position - 1 < len(self.history):
            self.position -= 1
            #print "ok"
            return self.history[self.position]
        return None

    def down(self):
        #print "down", self.position, self.history
        if self.position is not None and 0 <= self.position + 1 < len(self.history):
            self.position += 1
            #print "ok"
            return self.history[self.position]
        return None

    def add(self, text):
        self.history.append(text)
        self.position = len(self.history)
        #print "add", self.position, self.history

class MyWindow(Gtk.Window):
    def set_on_key_press(self, on_key_press):
        self.on_key_press = on_key_press

    def OnKeyPressEvent(self, event):
        return (self.on_key_press(event) or 
                Gtk.Window.OnKeyPressEvent(self, event))

class ShellWindow(Window):
    def __init__(self, project):
        self.project = project
        self.language = "python"
        self.window = MyWindow(_("Pyjama Shell"))
        self.window.set_on_key_press(self.on_key_press)
        self.window.SetDefaultSize(600, 550)
        self.window.DeleteEvent += Gtk.DeleteEventHandler(self.on_close)
	self.engine = EngineManager(self.project)
        self.engine.register(RubyEngine)
        self.engine.register(PythonEngine)
        self.engine.register(SchemeEngine)
        self.history_textview = Gtk.TextView()
        self.engine.start(self.history_textview, self.history_textview, None)
        self.vbox = Gtk.VBox()
        # ---------------------
        # make menu:
        menu = [("_File", 
                 [("Open Script...", Gtk.Stock.Open,
                   None, self.on_open_file),
                  ("New Script", Gtk.Stock.New,
                   None, self.on_new_file),
                  None,
                  ("Close", Gtk.Stock.Close,
                   None, self.on_close),
                  ("Quit", Gtk.Stock.Quit,
                   None, self.on_quit),
                  ]),
                ("_Edit", []),
                ("She_ll", self.make_language_menu()),
                ("Windows", [
                    ("Editor", None, "F6", self.project.setup_editor),
                    ("Shell", None, "F7", self.project.setup_shell),
                    ]),
                ("O_ptions", []),
                ("_Help", []),
                ]
        toolbar = [(Gtk.Stock.New, self.on_new_file),
                   (Gtk.Stock.Open, self.on_open_file),
                   (Gtk.Stock.Save, self.on_save_file), 
                   (Gtk.Stock.Quit, self.on_quit),]
        self.make_gui(menu, toolbar)
        self.history = History()
        self.statusbar = Gtk.Statusbar()
        self.statusbar.Show()
        self.statusbar.Push(1, "Language: Python")
        self.command_area = Gtk.HBox()
        alignment = Gtk.Alignment( 0.5, 0.0, 0, 0)
        self.prompt = Gtk.Label("python>")
        alignment.Add(self.prompt)
        self.command_area.PackStart(alignment, False, False, 0)
        self.scrolled_window = Gtk.ScrolledWindow()
        self.command_area.PackStart(self.scrolled_window, True, True, 0)
        self.scrolled_window.ShadowType = Gtk.ShadowType.Out
        self.scrolled_window.HeightRequest = 20
        self.textview = Gtk.TextView()
        #self.textview.KeyPressEvent += self.on_key_press
        self.textview.Show()
        self.textview.ModifyFont(Pango.FontDescription.FromString("Monospace 10"))
        self.scrolled_window.AddWithViewport(self.textview)
        self.results = Gtk.ScrolledWindow()
        for color in ["red", "blue", "green", "black"]:
            tag = Gtk.TextTag(color)
            tag.Weight = Pango.Weight.Bold
            tag.Foreground = color 
            self.history_textview.Buffer.TagTable.Add(tag)
        self.history_textview.ModifyFont(Pango.FontDescription.FromString("Monospace 10"))

        self.history_textview.WrapMode = Gtk.WrapMode.Word
        self.history_textview.Editable = False
        self.results.Add(self.history_textview)
        self.results.Show()
        self.vpane = Gtk.VPaned()
        self.vpane.Pack1(self.command_area, True, True)
        self.vpane.Pack2(self.results, True, True)
        # initialize
        self.window.Add(self.vbox)
        self.vbox.PackStart(self.menubar, False, False, 0)
        self.vbox.PackStart(self.toolbar, False, False, 0)
        self.vbox.PackStart(self.vpane, True, True, 0)
        self.vbox.PackEnd(self.statusbar, False, False, 0)
        self.window.ShowAll()
        # Set this Python's stderr:
        sys.stderr = CustomStream(self.history_textview, "red")
        self.update_gui()

    def make_language_menu(self):
        languages = []
        for (num, lang) in enumerate(self.engine.get_languages()):
            languages.append(["Change to %s" % lang.title(), 
                    None, "<control>%d" % (num + 1), 
                    lambda obj, event, lang=lang: self.change_to_lang(lang)])
        return ([("Run", Gtk.Stock.Apply, "F5", self.on_run)] + 
                languages +
                [("Reset Shell", None, "<control>r", self.reset_shell)])

    def update_gui(self):
        self.window.Title = _("%s - Pyjama Shell") % self.language.title()
        self.prompt.Text = "%-6s>" % self.language
        self.statusbar.Pop(0)
        self.statusbar.Push(0, _("Language: %s") % self.language.title())

    def on_key_press(self, event):
        if str(event.Key) == "Return":
            mark = self.textview.Buffer.InsertMark
            itermark = self.textview.Buffer.GetIterAtMark(mark)
            line = itermark.Line - 1
            iterline = self.textview.Buffer.GetIterAtLine(line)
            end = self.textview.Buffer.EndIter
            text = self.textview.Buffer.GetText(iterline, end, False)
            text = text.rstrip()
            if text == "":
                self.history.add(text)
                self.execute(text, self.language)
            elif text[-1] == ":":
                self.textview.Buffer.InsertAtCursor("\n    ")
            elif text[0] == " ":
                self.textview.Buffer.InsertAtCursor("\n    ")
            else:
                self.history.add(text)
                self.execute(text, self.language)
            return True
        elif str(event.Key) == "Up":
            mark = self.textview.Buffer.InsertMark
            itermark = self.textview.Buffer.GetIterAtMark(mark)
            line = itermark.Line
            #print "line:", line
            if line == 0:
                text = self.history.up()
                if text:
                    self.textview.Buffer.Text = text
                    return True
        elif str(event.Key) == "Down":
            mark = self.textview.Buffer.InsertMark
            itermark = self.textview.Buffer.GetIterAtMark(mark)
            line = itermark.Line
            if line == self.textview.Buffer.LineCount - 1:
                text = self.history.down()
                if text:
                    self.textview.Buffer.Text = text
                    return True
        return False

    def change_to_lang(self, language):
        self.language = language
        self.update_gui()

    def on_save_file_as(self, obj, event):
        pass

    def on_quit(self, obj, event):
        Gtk.Application.Quit()

    def on_close(self, obj, event):
        self.project.on_close("shell")
        return True

    def on_run(self, obj, event):
        pass

    # these aren't needed?
    def on_new_file(self, obj, event):
        pass
    def on_open_file(self, obj, event):
        pass
    def on_save_file(self, obj, event):
        pass

    def reset_shell(self, obj, event):
        self.engine.reset()
        self.message("-----------\n")
        self.message("Reset shell\n")
        self.message("-----------\n")

    def message(self, message, tag="green"):
        end = self.history_textview.Buffer.EndIter
        self.history_textview.Buffer.InsertWithTagsByName(end, message, tag)

    def execute_file(self, filename, language):
        return self.engine[language].execute_file(filename)

    def execute(self, text, language):
        self.textview.Buffer.Clear()
        prompt = "%-6s> " % language
        for line in text.split("\n"):
            end = self.history_textview.Buffer.EndIter
            self.history_textview.Buffer.InsertWithTagsByName(end, 
                             "%s" % prompt,
                             "black")
            end = self.history_textview.Buffer.EndIter
            self.history_textview.Buffer.InsertWithTagsByName(end, 
                             "%s\n" % line,
                             "blue")
            prompt = "......>"

        # pragma/meta commands, start with #;
        if text == "":
            return False
        elif text and text[0:2] == "#;":
            text = text[2:].strip()
            command = text.lower()
            if command in self.engine.get_languages():
                self.language = command
                self.update_gui()
                return True
            else:
                exec(text)
                return True
        self.language = language
        self.update_gui()
        return self.engine[self.language].execute(text)
