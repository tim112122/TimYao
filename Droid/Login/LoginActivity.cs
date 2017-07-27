
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

namespace timyao.Droid.Login
{
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

			// Create your application here

			// Set our view from the "main" layout resource
            SetContentView(Resource.Layout.login_loginView);


            //
            var button = FindViewById<Button>(Resource.Layout.login_loginView);

        }
    }
}
