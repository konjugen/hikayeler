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
using storie.Holders;

namespace storie
{
    public class StoryAdapter : RecyclerView.Adapter
    {
        private RecyclerView listViewStory;
        private StoryActivity storyActivity;
        private List<Story> items = new List<Story>();
        private string content, title;

        public StoryAdapter(StoryActivity storyActivity, RecyclerView listViewStory)
        {
            this.storyActivity = storyActivity;
            this.listViewStory = listViewStory;
        }

        public override int ItemCount
        {
            get { return items.Count; }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            StoryViewHolder sh = holder as StoryViewHolder;
            sh.text.Text = items[position].Title;
            holder.ItemView.Id = Convert.ToInt32(items[position].Id);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.Row_List_Story, parent, false);
            StoryViewHolder sh = new StoryViewHolder(itemView);
            itemView.Click += ÝtemView_Click;
            return sh;
        }

        private void ÝtemView_Click(object sender, EventArgs e)
        {
            
            Intent intent = new Intent(listViewStory.Context, typeof(ContentActivity));
            var id = ((View)sender).Id;
            var itemDetail = items.Where(item => item.Id == id.ToString()).ToList();
            foreach(var item in itemDetail)
            {
                content= item.Content;
                title = item.Title;
            }
            intent.PutExtra("selectedStoryId", id.ToString());
            intent.PutExtra("selectedStoryContent", content);
            intent.PutExtra("selectedStorieTitle", title);
            listViewStory.Context.StartActivity(intent);
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

    }
}