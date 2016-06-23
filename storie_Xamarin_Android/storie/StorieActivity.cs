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
using Android.Text.Method;

namespace storie
{
    [Activity(Label = "StorieActivity")]
    public class StorieActivity : Activity
    {
        public int selectedStorieId;
        public IList<string> selectedStorieContent, selectedStorieTitle;
        public TextView storieContentText, storieTitleText;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            selectedStorieContent = Intent.Extras.GetStringArrayList("selectedStorieContent");
            selectedStorieId = Intent.Extras.GetInt("selectedStorieId");
            selectedStorieTitle = Intent.Extras.GetStringArrayList("selectedStorieTitle");

            SetContentView(Resource.Layout.Activity_Storie);

            storieContentText = FindViewById<TextView>(Resource.Id.storieText);
            storieTitleText = FindViewById<TextView>(Resource.Id.storieTitleText);

            storieContentText.Text = selectedStorieContent[selectedStorieId];
            storieTitleText.Text = selectedStorieTitle[selectedStorieId];

            storieContentText.MovementMethod = new ScrollingMovementMethod();

        }
    }
}