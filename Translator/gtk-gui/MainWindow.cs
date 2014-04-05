
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action testAction;
	private global::Gtk.VBox vbox1;
	private global::Gtk.MenuBar menubar2;
	private global::Gtk.HBox hbox2;
	private global::Gtk.VBox vbox2;
	private global::Gtk.ComboBoxEntry from_lang;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TextView fromTextInput;
	private global::Gtk.VBox vbox3;
	private global::Gtk.CheckButton auto_translate_checkbox;
	private global::Gtk.Button change_languages_button;
	private global::Gtk.Button translate_button;
	private global::Gtk.VBox vbox4;
	private global::Gtk.ComboBoxEntry to_lang;
	private global::Gtk.ScrolledWindow GtkScrolledWindow1;
	private global::Gtk.TextView toTextInput;
	private global::Gtk.Statusbar statusbar1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.testAction = new global::Gtk.Action ("testAction", global::Mono.Unix.Catalog.GetString ("test"), null, null);
		this.testAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("test");
		w1.Add (this.testAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar2'><menu name='testAction' action='testAction'/></menubar></ui>");
		this.menubar2 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar2")));
		this.menubar2.Name = "menubar2";
		this.vbox1.Add (this.menubar2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar2]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.from_lang = global::Gtk.ComboBoxEntry.NewText ();
		this.from_lang.AppendText (global::Mono.Unix.Catalog.GetString ("English"));
		this.from_lang.AppendText (global::Mono.Unix.Catalog.GetString ("Russian"));
		this.from_lang.Name = "from_lang";
		this.vbox2.Add (this.from_lang);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.from_lang]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.fromTextInput = new global::Gtk.TextView ();
		this.fromTextInput.CanDefault = true;
		this.fromTextInput.CanFocus = true;
		this.fromTextInput.Name = "fromTextInput";
		this.GtkScrolledWindow.Add (this.fromTextInput);
		this.vbox2.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow]));
		w5.Position = 1;
		this.hbox2.Add (this.vbox2);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox2]));
		w6.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.auto_translate_checkbox = new global::Gtk.CheckButton ();
		this.auto_translate_checkbox.CanFocus = true;
		this.auto_translate_checkbox.Name = "auto_translate_checkbox";
		this.auto_translate_checkbox.Label = global::Mono.Unix.Catalog.GetString ("TranslateAuto");
		this.auto_translate_checkbox.DrawIndicator = true;
		this.auto_translate_checkbox.UseUnderline = true;
		this.vbox3.Add (this.auto_translate_checkbox);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.auto_translate_checkbox]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.change_languages_button = new global::Gtk.Button ();
		this.change_languages_button.CanFocus = true;
		this.change_languages_button.Name = "change_languages_button";
		this.change_languages_button.UseUnderline = true;
		this.change_languages_button.Label = global::Mono.Unix.Catalog.GetString ("ChangeLanguage");
		this.vbox3.Add (this.change_languages_button);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.change_languages_button]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.translate_button = new global::Gtk.Button ();
		this.translate_button.CanFocus = true;
		this.translate_button.Name = "translate_button";
		this.translate_button.UseUnderline = true;
		this.translate_button.Label = global::Mono.Unix.Catalog.GetString ("Translate");
		this.vbox3.Add (this.translate_button);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.translate_button]));
		w9.Position = 2;
		w9.Expand = false;
		w9.Fill = false;
		this.hbox2.Add (this.vbox3);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox3]));
		w10.Position = 1;
		w10.Expand = false;
		w10.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.to_lang = global::Gtk.ComboBoxEntry.NewText ();
		this.to_lang.AppendText (global::Mono.Unix.Catalog.GetString ("English"));
		this.to_lang.AppendText (global::Mono.Unix.Catalog.GetString ("Russian"));
		this.to_lang.Name = "to_lang";
		this.vbox4.Add (this.to_lang);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.to_lang]));
		w11.Position = 0;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.toTextInput = new global::Gtk.TextView ();
		this.toTextInput.CanFocus = true;
		this.toTextInput.Name = "toTextInput";
		this.GtkScrolledWindow1.Add (this.toTextInput);
		this.vbox4.Add (this.GtkScrolledWindow1);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.GtkScrolledWindow1]));
		w13.Position = 1;
		this.hbox2.Add (this.vbox4);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox4]));
		w14.Position = 2;
		this.vbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
		w15.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.statusbar1 = new global::Gtk.Statusbar ();
		this.statusbar1.Name = "statusbar1";
		this.statusbar1.Spacing = 6;
		this.vbox1.Add (this.statusbar1);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.statusbar1]));
		w16.Position = 2;
		w16.Expand = false;
		w16.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 644;
		this.DefaultHeight = 428;
		this.fromTextInput.HasDefault = true;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.translate_button.Clicked += new global::System.EventHandler (this.OnTranslateButtonClicked);
	}
}