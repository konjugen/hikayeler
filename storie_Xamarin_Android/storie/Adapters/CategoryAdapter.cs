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
using Android.Support.V7.Widget;
using XamarinTodoQuickStart;

namespace storie
{
    public class CategoryAdapter : RecyclerView.Adapter
    {
        private CategoryActivity categoryActivity;
        private RecyclerView listViewCategory;
        private List<Category> items = new List<Category>();

        public CategoryAdapter(CategoryActivity categoryActivity, RecyclerView listViewCategory)
        {
            this.categoryActivity = categoryActivity;
            this.listViewCategory = listViewCategory;
        }

        public override int ItemCount
        {
            get { return items.Count; }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            CategoryViewHolder ch = holder as CategoryViewHolder;
            ch.text.Text = items[position].CategoryName;
            holder.ItemView.Id = Convert.ToInt32(items[position].Id);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.Row_List_Category, parent, false);
            CategoryViewHolder ch = new CategoryViewHolder(itemView);
            itemView.Click += ÝtemView_Click;
            return ch;
        }

        private void ÝtemView_Click(object sender, EventArgs e)
        {
                Intent intent = new Intent(listViewCategory.Context, typeof(StoryActivity));
                var id = ((View)sender).Id;
                intent.PutExtra("selectedCategoryId", id.ToString());
                listViewCategory.Context.StartActivity(intent);
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
    }
}