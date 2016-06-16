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
    public class Category
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty(PropertyName = "fkMainCategoryId")]
        public string FkMainCategoryId{ get; set; }
    }

    public class CategoryItemWrapper : Java.Lang.Object
    {
        public CategoryItemWrapper(Category item)
        {
            CategoryItem = item;
        }

        public Category CategoryItem { get; private set; }
    }
}