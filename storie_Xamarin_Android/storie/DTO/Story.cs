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
using Newtonsoft.Json;

namespace storie
{
    public class Story
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        public string FkMainCategoryId { get; set; }

        public class StorieItemWrapper : Java.Lang.Object
        {
            public StorieItemWrapper(Story item)
            {
                StorieItem = item;
            }

            public Story StorieItem { get; private set; }
        }
    }
}