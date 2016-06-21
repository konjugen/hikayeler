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
        public string selectedItemContent;
        public TextView asd;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            selectedItemContent = Intent.Extras.GetString("selectedStorie");           

            SetContentView(Resource.Layout.Activity_Storie);

            var asd = FindViewById<TextView>(Resource.Id.textView1);

            asd.Text = selectedItemContent;


        }
    }
}