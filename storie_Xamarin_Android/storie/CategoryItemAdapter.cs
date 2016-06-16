using System;
using Android.App;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;
using XamarinTodoQuickStart;
using storie;

namespace XamarinTodoQuickStart
{
    public class CategoryItemAdapter : BaseAdapter<Category>
    {
        // Private Variables
        private Activity activity;
        private int layoutResourceId;
        private List<Category> items = new List<Category>();
        //Button button;
        LinearLayout layout;
        TextView text;

        // Constructor
        public CategoryItemAdapter(Activity activity, int layoutResourceId)
        {
            this.activity = activity;
            this.layoutResourceId = layoutResourceId;
        }

        // Returns the view for a specific item on the list
        public override View GetView(int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
        {
            var row = convertView;
            var currentItem = this[position];
            //CheckBox checkBox;
           
            if (row == null)
            {
                var inflater = activity.LayoutInflater;
                row = inflater.Inflate(layoutResourceId, null);

                //button = row.FindViewById<Button>(Resource.Id.categoryButton);
                layout = row.FindViewById<LinearLayout>(Resource.Id.categoryLayout);
                text = layout.FindViewById<TextView>(Resource.Id.categoryText);

                //checkBox.CheckedChange += async (sender, e) => {
                //    var cbSender = sender as CheckBox;
                //    if (cbSender != null && cbSender.Tag is CategoryItemWrapper && cbSender.Checked)
                //    {
                //        cbSender.Enabled = false;

                //        if (activity is TodoActivity)
                //            await ((TodoActivity)activity).CheckItem((cbSender.Tag as CategoryItemWrapper).CategoryItem);
                //    }
                //};
            }
            else
            {
                //button = row.FindViewById<Button>(Resource.Id.categoryButton);
                layout = row.FindViewById<LinearLayout>(Resource.Id.categoryLayout);
            }

            text.Text = currentItem.CategoryName;
            text.Enabled = true;
            text.Tag = new CategoryItemWrapper(currentItem);

            //button.Text = currentItem.CategoryName;
            //button.Enabled = true;
            //button.Tag = new CategoryItemWrapper(currentItem);

            return row;
        }
        public void Add(Category item)
        {
            items.Add(item);
            NotifyDataSetChanged();
        }

        public void Clear()
        {
            items.Clear();
            NotifyDataSetChanged();
        }

        public void Remove(Category item)
        {
            items.Remove(item);
            NotifyDataSetChanged();
        }

        #region implemented abstract members of BaseAdapter

        public override long GetItemId(int position)
        {
            return position;
        }

        public void OnItemClick(AdapterView parent, View view, int position, long id)
        {
            throw new NotImplementedException();
        }

        public override int Count
        {
            get { return items.Count; }
        }

        public override Category this[int position]
        {
            get { return items[position]; }
        }

        #endregion
    }
}
