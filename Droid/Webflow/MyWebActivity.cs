
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Webkit;

namespace timyao.Droid.Webflow
{
    [Activity(Label = "MY web",MainLauncher = true)]
    public class MyWebActivity : Activity
    {
        private Button btnGOGO { get; set; }
		private EditText txtUrl { get; set; }
		private WebView MyWebView { get; set; }


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.mywebview);

            btnGOGO = FindViewById<Button>(Resource.Id.mywebview_btngo);
            txtUrl = FindViewById<EditText>(Resource.Id.mywebview_txturl);
            MyWebView = FindViewById<WebView>(Resource.Id.mywebview_webview);

            //
            var urlstring = Intent.GetStringExtra("myrul") ?? "https://www.google.com";

            btnGOGO.Click += (sender, e) =>
            {
                var urlString = txtUrl.Text;
                //ShowAlert("Alert", urlString, (object alertsender, DialogClickEventArgs alerte) =>
                //{


                //});

                MyWebView.LoadUrl(urlstring);
            };
        }
		private void ShowAlert(string title, string message, EventHandler<Android.Content.DialogClickEventArgs> positiveButtonClickHandle)
		{

			AlertDialog.Builder alert = new AlertDialog.Builder(this);

			alert.SetTitle(title);
			alert.SetMessage(message);

			alert.SetPositiveButton("Confirm", positiveButtonClickHandle);

			RunOnUiThread(() =>
			{
				alert.Show();
			});

		}

    }
}
