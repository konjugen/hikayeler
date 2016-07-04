using System;
using Android.App;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;
using XamarinTodoQuickStart;
using storie;
using static storie.Story;

namespace storie
{
    public class StoryItemAdapter : BaseAdapter<Story>
    {
        private Activity activity;
        private int layoutResourceId;
        private List<Story> items = new List<Story>();
        LinearLayout layout;
        TextView text;
        public StoryItemAdapter(Activity activity, int layoutResourceId)
        {
            this.activity = activity;
            this.layoutResourceId = layoutResourceId;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var row = convertView;
            var currentItem = this[position]; 

            if (row == null)
            {
                var inflater = activity.LayoutInflater;
                row = inflater.Inflate(layoutResourceId, null);

                layout = row.FindViewById<LinearLayout>(Resource.Id.storieLayout);
                text = layout.FindViewById<TextView>(Resource.Id.storieText);

            }
            else
            {
                layout = row.FindViewById<LinearLayout>(Resource.Id.categoryLayout);
            }

            text.Text = currentItem.Title;
            text.Enabled = true;
            text.Tag = new StorieItemWrapper(currentItem);

            return row;
        }

        public void Add(Story item)
        {
            items.Add(item);
            NotifyDataSetChanged();
        }

        public void Clear()
        {
            items.Clear();
            NotifyDataSetChanged();
        }

        public void Remove(Story item)
        {
            items.Remove(item);
            NotifyDataSetChanged();
        }

        #region implemented abstract members of BaseAdapter
        public override Story this[int position]
        {
            get { return items[position]; } 
        }

        public override int Count
        {
            get { return items.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }
        #endregion
    }
}