
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace Groceryapp
{
    [Activity(Label = "DetailsActivity")]
    public class DetailsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Details);

            var position = Intent.GetIntExtra("ItemPosition", -1);

            FindViewById<TextView>(Resource.Id.nameView).Text = "Name: " +MainActivity.Articles[position].Name;
            FindViewById<TextView>(Resource.Id.countView).Text = "Count: " + MainActivity.Articles[position].Count.ToString();
                

                // Create your application here
        }
    }
}