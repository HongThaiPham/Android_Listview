using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Android_Listview
{
    [Activity(Label = "Android_Listview", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        private List<Person> mItem;
        private ListView mListView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mListView = FindViewById<ListView>(Resource.Id.myListView);


            mItem = new List<Person>();
            mItem.Add(new Person {FirstName="Pham",LastName="Thai",Age="26", Gender="Male" });
            mItem.Add(new Person { FirstName = "Leo", LastName = "Pham", Age = "26", Gender = "Male" });
            mItem.Add(new Person { FirstName = "Ga", LastName = "Chu", Age = "23", Gender = "Female" });

            //ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItem);
            MyListViewAdapter adapter = new MyListViewAdapter(this, mItem);

            mListView.Adapter = adapter;
            mListView.ItemClick += MListView_ItemClick;
            mListView.ItemLongClick += MListView_ItemLongClick;
        }

        private void MListView_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            Console.WriteLine(mItem[e.Position].LastName);
        }

        private void MListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Console.WriteLine(mItem[e.Position].FirstName);
        }
    }
}

