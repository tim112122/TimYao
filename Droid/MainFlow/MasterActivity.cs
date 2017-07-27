
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

namespace timyao.Droid.MainFlow
{
    [Activity(Label = "MasterActivity")]
    public class MasterActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

			// Create your application here

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.masterView);

			// Get our button from the layout resource,
			// and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.masterview_btnconfirm);


			button.Click += delegate
			{
				var intent = new Intent(this, typeof(Login.LoginActivity));

				StartActivity(intent);

			};


        }
    }
}
