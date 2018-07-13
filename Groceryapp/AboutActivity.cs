using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using System;

namespace Groceryapp
{
    [Activity(Label = "About")]
    public class AboutActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.About);
            FindViewById<Button>(Resource.Id.learnMoreButton).Click += OnLearnClick;
            // Create your application here
        }

        private void OnLearnClick(object sender, EventArgs e)
        {
            var intent = new Intent();
            intent.SetAction(Intent.ActionView);
            intent.SetData(Android.Net.Uri.Parse("http://www.vinayaksharma.blog"));
            StartActivity(intent);
        }
    }
}