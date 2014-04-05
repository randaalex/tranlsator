using System;
using Gtk;

using System.Linq;	
using GoogleApi.Translate;


public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	protected void OnTranslateButtonClicked (object sender, EventArgs e)
	{
		string fromText = "";
		string toText = "";
	
//		TranslateClient translator = new TranslateClient("");
//    
//		string translated = translator.Translate(text, Language.English, Language.Russian);
//
		fromTextInput.Buffer.Text = "hello";

		fromText = fromTextInput.Buffer.Text;
//		var collection = Google.API.Translate.Language.TranslatableCollection;
//
//		foreach(Language language in collection)
//		{
//			toText = toText + language.ToString() + "\n";
////			language.ToString());
//		}
//
//		var client = new TranslateClient("tut.by");
//		toText = client.Translate(fromText, Language.English, Language.Russian, TranslateFormat.Text);
//			
		toTextInput.Buffer.Text = new Client();
	}
}