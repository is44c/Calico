
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HPaned hpaned1;
	private global::Gtk.VBox vbox7;
	private global::Gtk.ScrolledWindow scrolledwindow1;
	private global::Gtk.VBox vbox6;
	private global::Gtk.VBox _menu;
	private global::Gtk.Button button8;
	private global::Gtk.ScrolledWindow scrolledwindow2;
	private global::Gtk.VBox _program;
	private global::Gtk.Frame frame8;
	private global::Gtk.Alignment GtkAlignment1;
	private global::Gtk.VBox vbox11;
	private global::Gtk.HBox hbox17;
	private global::Gtk.Button button11;
	private global::Gtk.VBox vbox12;
	private global::Gtk.HBox hbox18;
	private global::Gtk.Label label25;
	private global::Gtk.Entry entry11;
	private global::Gtk.Expander expander52;
	private global::Gtk.Frame frame9;
	private global::Gtk.Alignment GtkAlignment2;
	private global::Gtk.HBox hbox19;
	private global::Gtk.Button button12;
	private global::Gtk.Label label26;
	private global::Gtk.Entry entry12;
	private global::Gtk.Label GtkLabel3;
    
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.hpaned1 = new global::Gtk.HPaned ();
		this.hpaned1.CanFocus = true;
		this.hpaned1.Name = "hpaned1";
		this.hpaned1.Position = 143;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.vbox7 = new global::Gtk.VBox ();
		this.vbox7.Name = "vbox7";
		this.vbox7.Spacing = 6;
		// Container child vbox7.Gtk.Box+BoxChild
		this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
		this.scrolledwindow1.CanFocus = true;
		this.scrolledwindow1.Name = "scrolledwindow1";
		this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrolledwindow1.Gtk.Container+ContainerChild
		global::Gtk.Viewport w1 = new global::Gtk.Viewport ();
		w1.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport.Gtk.Container+ContainerChild
		this.vbox6 = new global::Gtk.VBox ();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this._menu = new global::Gtk.VBox ();
		this._menu.Name = "_menu";
		this._menu.Spacing = 6;
		this.vbox6.Add (this._menu);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this._menu]));
		w2.Position = 0;
		w1.Add (this.vbox6);
		this.scrolledwindow1.Add (w1);
		this.vbox7.Add (this.scrolledwindow1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.scrolledwindow1]));
		w5.Position = 0;
		// Container child vbox7.Gtk.Box+BoxChild
		this.button8 = new global::Gtk.Button ();
		this.button8.WidthRequest = 30;
		this.button8.CanFocus = true;
		this.button8.Name = "button8";
		this.button8.UseUnderline = true;
		// Container child button8.Gtk.Container+ContainerChild
		global::Gtk.Alignment w6 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w7 = new global::Gtk.HBox ();
		w7.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w8 = new global::Gtk.Image ();
		w8.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "stock_trash_full", global::Gtk.IconSize.Dialog);
		w7.Add (w8);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w10 = new global::Gtk.Label ();
		w7.Add (w10);
		w6.Add (w7);
		this.button8.Add (w6);
		this.vbox7.Add (this.button8);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.button8]));
		w14.Position = 1;
		w14.Expand = false;
		w14.Fill = false;
		this.hpaned1.Add (this.vbox7);
		global::Gtk.Paned.PanedChild w15 = ((global::Gtk.Paned.PanedChild)(this.hpaned1 [this.vbox7]));
		w15.Resize = false;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.scrolledwindow2 = new global::Gtk.ScrolledWindow ();
		this.scrolledwindow2.CanFocus = true;
		this.scrolledwindow2.Name = "scrolledwindow2";
		this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrolledwindow2.Gtk.Container+ContainerChild
		global::Gtk.Viewport w16 = new global::Gtk.Viewport ();
		w16.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport1.Gtk.Container+ContainerChild
		this._program = new global::Gtk.VBox ();
		this._program.Name = "_program";
		this._program.Spacing = 6;
		// Container child _program.Gtk.Box+BoxChild
		this.frame8 = new global::Gtk.Frame ();
		this.frame8.Name = "frame8";
		// Container child frame8.Gtk.Container+ContainerChild
		this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment1.Name = "GtkAlignment1";
		this.GtkAlignment1.LeftPadding = ((uint)(12));
		// Container child GtkAlignment1.Gtk.Container+ContainerChild
		this.vbox11 = new global::Gtk.VBox ();
		this.vbox11.Name = "vbox11";
		this.vbox11.Spacing = 6;
		// Container child vbox11.Gtk.Box+BoxChild
		this.hbox17 = new global::Gtk.HBox ();
		this.hbox17.Name = "hbox17";
		this.hbox17.Spacing = 6;
		// Container child hbox17.Gtk.Box+BoxChild
		this.button11 = new global::Gtk.Button ();
		this.button11.CanFocus = true;
		this.button11.Name = "button11";
		this.button11.UseUnderline = true;
		// Container child button11.Gtk.Container+ContainerChild
		global::Gtk.Alignment w17 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w18 = new global::Gtk.HBox ();
		w18.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w19 = new global::Gtk.Image ();
		w19.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-justify-fill", global::Gtk.IconSize.Menu);
		w18.Add (w19);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w21 = new global::Gtk.Label ();
		w18.Add (w21);
		w17.Add (w18);
		this.button11.Add (w17);
		this.hbox17.Add (this.button11);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox17 [this.button11]));
		w25.Position = 0;
		w25.Expand = false;
		w25.Fill = false;
		// Container child hbox17.Gtk.Box+BoxChild
		this.vbox12 = new global::Gtk.VBox ();
		this.vbox12.Name = "vbox12";
		this.vbox12.Spacing = 6;
		// Container child vbox12.Gtk.Box+BoxChild
		this.hbox18 = new global::Gtk.HBox ();
		this.hbox18.Name = "hbox18";
		this.hbox18.Spacing = 6;
		// Container child hbox18.Gtk.Box+BoxChild
		this.label25 = new global::Gtk.Label ();
		this.label25.Name = "label25";
		this.label25.LabelProp = global::Mono.Unix.Catalog.GetString ("label25");
		this.hbox18.Add (this.label25);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox18 [this.label25]));
		w26.Position = 0;
		w26.Expand = false;
		w26.Fill = false;
		// Container child hbox18.Gtk.Box+BoxChild
		this.entry11 = new global::Gtk.Entry ();
		this.entry11.CanFocus = true;
		this.entry11.Name = "entry11";
		this.entry11.IsEditable = true;
		this.entry11.InvisibleChar = '•';
		this.hbox18.Add (this.entry11);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox18 [this.entry11]));
		w27.Position = 1;
		this.vbox12.Add (this.hbox18);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox12 [this.hbox18]));
		w28.Position = 0;
		w28.Expand = false;
		w28.Fill = false;
		// Container child vbox12.Gtk.Box+BoxChild
		this.expander52 = new global::Gtk.Expander (null);
		this.expander52.CanFocus = true;
		this.expander52.Name = "expander52";
		// Container child expander52.Gtk.Container+ContainerChild
		this.frame9 = new global::Gtk.Frame ();
		this.frame9.Name = "frame9";
		this.frame9.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child frame9.Gtk.Container+ContainerChild
		this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment2.Name = "GtkAlignment2";
		this.GtkAlignment2.LeftPadding = ((uint)(12));
		// Container child GtkAlignment2.Gtk.Container+ContainerChild
		this.hbox19 = new global::Gtk.HBox ();
		this.hbox19.Name = "hbox19";
		this.hbox19.Spacing = 6;
		// Container child hbox19.Gtk.Box+BoxChild
		this.button12 = new global::Gtk.Button ();
		this.button12.CanFocus = true;
		this.button12.Name = "button12";
		this.button12.UseUnderline = true;
		this.button12.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
		this.hbox19.Add (this.button12);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox19 [this.button12]));
		w29.Position = 0;
		w29.Expand = false;
		w29.Fill = false;
		// Container child hbox19.Gtk.Box+BoxChild
		this.label26 = new global::Gtk.Label ();
		this.label26.Name = "label26";
		this.label26.LabelProp = global::Mono.Unix.Catalog.GetString ("label26");
		this.hbox19.Add (this.label26);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox19 [this.label26]));
		w30.Position = 1;
		w30.Expand = false;
		w30.Fill = false;
		// Container child hbox19.Gtk.Box+BoxChild
		this.entry12 = new global::Gtk.Entry ();
		this.entry12.CanFocus = true;
		this.entry12.Name = "entry12";
		this.entry12.IsEditable = true;
		this.entry12.WidthChars = 10;
		this.entry12.InvisibleChar = '•';
		this.hbox19.Add (this.entry12);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox19 [this.entry12]));
		w31.Position = 2;
		this.GtkAlignment2.Add (this.hbox19);
		this.frame9.Add (this.GtkAlignment2);
		this.expander52.Add (this.frame9);
		this.GtkLabel3 = new global::Gtk.Label ();
		this.GtkLabel3.Name = "GtkLabel3";
		this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString ("GtkExpander");
		this.GtkLabel3.UseUnderline = true;
		this.expander52.LabelWidget = this.GtkLabel3;
		this.vbox12.Add (this.expander52);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox12 [this.expander52]));
		w35.Position = 1;
		w35.Expand = false;
		w35.Fill = false;
		this.hbox17.Add (this.vbox12);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox17 [this.vbox12]));
		w36.Position = 1;
		this.vbox11.Add (this.hbox17);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.hbox17]));
		w37.Position = 0;
		this.GtkAlignment1.Add (this.vbox11);
		this.frame8.Add (this.GtkAlignment1);
		this._program.Add (this.frame8);
		global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this._program [this.frame8]));
		w40.Position = 0;
		w40.Expand = false;
		w16.Add (this._program);
		this.scrolledwindow2.Add (w16);
		this.hpaned1.Add (this.scrolledwindow2);
		this.Add (this.hpaned1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 570;
		this.DefaultHeight = 421;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
