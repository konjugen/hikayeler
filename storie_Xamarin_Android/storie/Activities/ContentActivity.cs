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
    public class ContentActivity : Activity
    {

        public string selectedStorieContent, selectedStorieTitle, selectedStorieId;
        public TextView storieContentText, storieTitleText;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            selectedStorieContent = Intent.Extras.GetString("selectedStoryContent");
            selectedStorieId = Intent.Extras.GetString("selectedStorieId");
            selectedStorieTitle = Intent.Extras.GetString("selectedStorieTitle");

            SetContentView(Resource.Layout.Activity_Content);

            storieContentText = FindViewById<TextView>(Resource.Id.storieText);
            storieTitleText = FindViewById<TextView>(Resource.Id.storieTitleText);

            storieContentText.Text = selectedStorieContent;
            storieTitleText.Text = selectedStorieTitle;

            storieContentText.MovementMethod = new ScrollingMovementMethod();

        }
    }
}