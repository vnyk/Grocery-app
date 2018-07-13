using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using System;

namespace Groceryapp
{
    [Activity(Label = "AddItem")]
    public class AddItemActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.AddItem);

            FindViewById<Button>(Resource.Id.cancelButton).Click += OnCanclClick;
            FindViewById<Button>(Resource.Id.saveButton).Click += OnSaveClick; 

            // Create your application here
        }

        void OnSaveClick(object sender, EventArgs e)
        {

            try
            {
                string name = FindViewById<TextView>(Resource.Id.nameInput).Text;
                int count = int.Parse(FindViewById<TextView>(Resource.Id.countInput).Text);
                var intent = new Intent();
                intent.PutExtra("ItemName", name);
                intent.PutExtra("ItemCount", count);

                SetResult(Result.Ok, intent);
                //MainActivity.Articles.Add(new Item(name, count));
                Finish();
            }
            catch(Exception)
            {
                Toast.MakeText(this, "Enter details", ToastLength.Long);
            }
        }

        void OnCanclClick(object sender, EventArgs e)
        {
            Finish();
        }
    }
}