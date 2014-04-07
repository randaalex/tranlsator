using System;
using Gtk;

using System.Linq;	
using System.Net;	
using System.IO;

using Translator.TranslateApi.Bing;

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
		string fromText = fromTextInput.Buffer.Text;
		string toText = "";
	
		AdmAuthentication admAuth = new AdmAuthentication("", "");
		AdmAccessToken admToken = admAuth.GetAccessToken();

		string encodedFromText = System.Web.HttpUtility.UrlEncode(fromText);
		string uri = "http://api.microsofttranslator.com/v2/Http.svc/Translate?text=" + System.Web.HttpUtility.UrlEncode(fromText) + "&from=" + "en" + "&to=" + "ru";
		string authToken = "Bearer" + " " + admToken.access_token;

		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
		httpWebRequest.Headers.Add("Authorization", authToken);

		WebResponse response = httpWebRequest.GetResponse();
//		try
//		{
			response = httpWebRequest.GetResponse();
			using (Stream stream = response.GetResponseStream())
			{
			System.Runtime.Serialization.DataContractSerializer dcs = new System.Runtime.Serialization.DataContractSerializer(System.Type.GetType("System.String"));
			    toText = (string)dcs.ReadObject(stream);
			}
//		}

		toTextInput.Buffer.Text = toText;
	}
}