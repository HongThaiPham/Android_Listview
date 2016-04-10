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
        private List<string> mItem;
        private ListView mListView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mListView = FindViewById<ListView>(Resource.Id.myListView);


            mItem = new List<string>
            {
                "Pham",
                "Hong",
                "Thai"
            };

            //ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItem);
            MyListViewAdapter adapter = new MyListViewAdapter(this, mItem);

            mListView.Adapter = adapter;
        }
    }
}

