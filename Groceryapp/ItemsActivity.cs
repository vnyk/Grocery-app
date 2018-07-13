
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace Groceryapp
{
    [Activity(Label = "Items")]
    public class ItemsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Items);

            // Create your application here

            var lisv = FindViewById<ListView>(Resource.Id.Listview);
            lisv.Adapter = new ArrayAdapter<Item>(this, Android.Resource.Layout.SimpleListItem1, Android.Resource.Id.Text1, MainActivity.Articles);

            lisv.ItemClick += OnItemClick;
        }

        private void OnItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var inttent = new Intent(this, typeof(DetailsActivity));
                       
            int pos = e.Position;

            inttent.PutExtra("ItemPosition", pos);
            StartActivity(inttent);
        }
    }
}