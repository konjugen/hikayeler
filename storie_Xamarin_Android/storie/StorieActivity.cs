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

namespace storie
{
    [Activity(Label = "StorieActivity")]
    public class StorieActivity : Activity
    {
        public int selectedItem;
        public IList<string> selectedItemContent;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            selectedItem = Intent.Extras.GetInt("selectedItemId");
            selectedItem = selectedItem + 1;
            selectedItemContent = Intent.Extras.GetStringArrayList("selectedStorie");

            SetContentView(Resource.Layout.Activity_Storie);
        }
    }
}