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

namespace storie.Holders
{
    public class StoryViewHolder : RecyclerView.ViewHolder
    {
        public TextView text { get; set; }
        public LinearLayout layout { get; set; }
        public TextView Content { get; set; }

        public StoryViewHolder(View itemView) : base(itemView)
        {
            layout = itemView.FindViewById<LinearLayout>(Resource.Id.storieLayout);
            text = itemView.FindViewById<TextView>(Resource.Id.storieText);
        }
    }
}