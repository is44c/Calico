
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HPaned hpaned1;
	private global::Gtk.ScrolledWindow scrolledwindow1;
	private global::Gtk.VBox vbox1;
	private global::Gtk.VBox vbox5;
	private global::Gtk.Expander expander4;
	private global::Gtk.Label GtkLabel8;
    
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
		this.hpaned1.Position = 212;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
		this.scrolledwindow1.CanFocus = true;
		this.scrolledwindow1.Name = "scrolledwindow1";
		this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrolledwindow1.Gtk.Container+ContainerChild
		global::Gtk.Viewport w1 = new global::Gtk.Viewport ();
		w1.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		w1.Add (this.vbox1);
		this.scrolledwindow1.Add (w1);
		this.hpaned1.Add (this.scrolledwindow1);
		global::Gtk.Paned.PanedChild w4 = ((global::Gtk.Paned.PanedChild)(this.hpaned1 [this.scrolledwindow1]));
		w4.Resize = false;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.vbox5 = new global::Gtk.VBox ();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 6;
		// Container child vbox5.Gtk.Box+BoxChild
		this.expander4 = new global::Gtk.Expander (null);
		this.expander4.CanFocus = true;
		this.expander4.Name = "expander4";
		this.expander4.Expanded = true;
		this.GtkLabel8 = new global::Gtk.Label ();
		this.GtkLabel8.Name = "GtkLabel8";
		this.GtkLabel8.LabelProp = global::Mono.Unix.Catalog.GetString ("Begin");
		this.GtkLabel8.UseUnderline = true;
		this.expander4.LabelWidget = this.GtkLabel8;
		this.vbox5.Add (this.expander4);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.expander4]));
		w5.Position = 0;
		this.hpaned1.Add (this.vbox5);
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
