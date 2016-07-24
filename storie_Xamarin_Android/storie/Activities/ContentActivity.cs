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
using Android.Gms.Ads;

namespace storie
{
    [Activity(Icon = "@drawable/launcher_nokta", Label = "@string/app_name")]
    public class ContentActivity : Activity
    {

        public string selectedStorieContent, selectedStorieTitle, selectedStorieId;
        public TextView storieContentText, storieTitleText;

        protected AdView mAdView;
        protected InterstitialAd mInterstitialAd;
        protected Button mLoadInterstitialButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            GAService.GetGASInstance().Initialize(this);

            selectedStorieContent = Intent.Extras.GetString("selectedStoryContent");
            selectedStorieId = Intent.Extras.GetString("selectedStorieId");
            selectedStorieTitle = Intent.Extras.GetString("selectedStorieTitle");

            SetContentView(Resource.Layout.Activity_Content);

            storieContentText = FindViewById<TextView>(Resource.Id.storieText);
            storieTitleText = FindViewById<TextView>(Resource.Id.storieTitleText);

            storieContentText.Text = selectedStorieContent;
            storieTitleText.Text = selectedStorieTitle;

            storieContentText.MovementMethod = new ScrollingMovementMethod();

            mAdView = FindViewById<AdView>(Resource.Id.adViewContent);
            var adRequest = new AdRequest.Builder().Build();
            mAdView.LoadAd(adRequest);

        }

        #region
        protected override void OnPause()
        {
            if (mAdView != null)
            {
                mAdView.Pause();
            }
            base.OnPause();
        }

        protected override void OnResume()
        {
            base.OnResume();
            if (mAdView != null)
            {
                mAdView.Resume();
            }
        }

        protected override void OnDestroy()
        {
            if (mAdView != null)
            {
                mAdView.Destroy();
            }
            base.OnDestroy();
        }

        #endregion

    }
}