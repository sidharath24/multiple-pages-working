using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Content;
using Android.Widget;
using Multiple_Pages.Resources.layout;

namespace Multiple_Pages
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public static EditText UserNameET, PasswordET;
        Button LogInBtn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            UserNameET = (EditText)FindViewById(Resource.Id.ETUserName);
            PasswordET = (EditText)FindViewById(Resource.Id.ETPassword);
            LogInBtn = (Button)FindViewById(Resource.Id.BtnLogin);
            LogInBtn.Click += delegate
            {
                if (UserNameET.Text == "" || PasswordET.Text == "")
                {
                    Toast.MakeText(this, "Please enter username and password : ", ToastLength.Long).Show();
                }
                else if (UserNameET.Text == "admin" || PasswordET.Text == "12345678")
                {
                    Intent intent = new Intent(this, typeof(Page2Activity));
                    StartActivity(intent);
                }
            };
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
	}
}

