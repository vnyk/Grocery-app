using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using System;
using System.Collections.Generic;

namespace Groceryapp
{
    [Activity(Label = "Groceryapp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        public static List<Item> Articles = new List<Item>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            Articles.Add(new Item("Milk", 2));
            Articles.Add(new Item("Bread", 5));
            Articles.Add(new Item("Bingo", 3));
            base.OnCreate(savedInstanceState);
                

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            // Invoke buttons
            FindViewById<Button>(Resource.Id.itemsButton).Click += OnItemsClick;
            FindViewById<Button>(Resource.Id.addItemButton).Click += OnAddItemClick;
            FindViewById<Button>(Resource.Id.aboutButton).Click += OnAboutClick;

        }

        void OnItemsClick(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(ItemsActivity));
            StartActivity(intent);
        }

        void OnAddItemClick(object srnder, EventArgs e)
        {
            var intent = new Intent(this, typeof(AddItemActivity));
            StartActivityForResult(intent, 100);
        }

        void OnAboutClick(object sender, EventArgs e)
        {
            //var intent = new Intent(this, typeof(AboutActivity));
            StartActivity(typeof(AboutActivity));
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            if (requestCode == 100 && resultCode == Result.Ok)
            {
                String namee = data.GetStringExtra("ItemName");
                int countt = data.GetIntExtra("ItemCount", 0);
                Articles.Add(new Item(namee, countt));
            }
        }
    }
}

