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

namespace Android_Listview
{
    class MyListViewAdapter : BaseAdapter<Person>
    {
        private List<Person> mItems;
        private Context mContext;

        public MyListViewAdapter(Context context, List<Person> items)
        {
            mContext = context;
            mItems = items;
        }

        public override int Count
        {
            get
            {
                return mItems.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Person this[int position]
        {
            get
            {
                return mItems[position];
            }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.ListView_row, null, false);
            }

            TextView textView = row.FindViewById<TextView>(Resource.Id.txtName);
            textView.Text = mItems[position].FirstName;

            TextView lastName = row.FindViewById<TextView>(Resource.Id.txtLastName);
            lastName.Text = mItems[position].LastName;

            TextView age = row.FindViewById<TextView>(Resource.Id.txtAge);
            age.Text = mItems[position].Age;

            TextView gender = row.FindViewById<TextView>(Resource.Id.txtGender);
            lastName.Text = mItems[position].Gender;


            return row;
        }
    }
}