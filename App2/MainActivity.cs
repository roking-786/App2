using System;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.App;
using Android.Widget;
using Android.OS;

namespace App2
{
    [Activity(Label = "App2", MainLauncher = true)]
    public class MainActivity : Activity
    {
        int count = 1;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            Button button = FindViewById<Button> (Resource.Id.myButton);
            button.Click += delegate
            {
                button.Text = string.Format("{0} clicks!", count++);
                button.SetBackgroundColor(Android.Graphics.Color.White);
            };

            button.LongClick += delegate
            {
                Toast.MakeText(this, "long click", ToastLength.Short).Show();
                button.SetBackgroundColor(Android.Graphics.Color.Aqua);
            };

            

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }

      //  private void Button_Click(object sender, EventArgs e)
        //{
          //  throw new NotImplementedException();
        //}
    }
}

