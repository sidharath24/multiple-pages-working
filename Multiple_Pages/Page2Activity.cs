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

namespace Multiple_Pages.Resources.layout
{
    [Activity(Label = "Page2Activity")]
    public class Page2Activity : Activity
    {
        public static Button BackBtn;
        public static TextView WelcomeTv;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.page2);
            BackBtn = (Button)FindViewById(Resource.Id.BtnBack);
            WelcomeTv = (TextView)FindViewById(Resource.Id.TvWelcome);

            WelcomeTv.Text = "Hey " + MainActivity.UserNameET.Text + ". This is a new page";

            BackBtn.Click += delegate
            {
                Intent intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };

            // Create your application here
        }
    }
}