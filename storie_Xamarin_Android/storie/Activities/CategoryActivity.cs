using System;
using Android.OS;
using Android.App;
using Android.Views;
using Android.Widget;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

// TODO:: Add the following using statement
// using Microsoft.WindowsAzure.MobileServices;
using System.Collections.Generic;
using storie;
using Android.Content;
using Android.Support.V7.Widget;
using Android.Gms.Ads;

namespace XamarinTodoQuickStart
{
    [Activity(MainLauncher = true,
               Icon = "@drawable/launcher_nokta", Label = "@string/app_name",
               Theme = "@style/AppTheme")]

    public class CategoryActivity : Activity, AdapterView.IOnItemClickListener
    {
        // TODO:: Uncomment the following two lines of code to use Mobile Services
        private MobileServiceClient client; // Mobile Service Client reference		
        private IMobileServiceTable<Category> categoryTable; // Mobile Service Table used to access data     

        // TODO:: Comment out this line to remove the in-memory list
        public List<Category> categoryItemList = new List<Category>();

        private CategoryAdapter adapter;
        // Adapter to sync the items list with the view
        private RecyclerView listViewCategory;

        protected AdView mAdView;
        protected InterstitialAd mInterstitialAd;

        //private EditText textNewTodo; // EditText containing the "New Todo" text
        //private ProgressBar progressBar; // Progress spinner to use for table operations  

        // Called when the activity initially gets created
        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Activity_Category);

            mAdView = FindViewById<AdView>(Resource.Id.adView);
            var adRequest = new AdRequest.Builder().Build();
            mAdView.LoadAd(adRequest);

            //adapter = new CategoryItemAdapter(this, Resource.Layout.Row_List_Category);

            //listViewCategory = FindViewById<ListView>(Resource.Id.listViewCategory);
            //listViewCategory.OnItemClickListener = this;

            //listViewCategory.Adapter = adapter;

            adapter = new CategoryAdapter(this, FindViewById<RecyclerView>(Resource.Id.listViewCategory));

            listViewCategory = (RecyclerView)FindViewById(Resource.Id.listViewCategory);
           
            listViewCategory.SetLayoutManager(new LinearLayoutManager(this));

            listViewCategory.SetAdapter(adapter);


            // Initialize the progress bar
            //progressBar = FindViewById<ProgressBar>(Resource.Id.loadingProgressBar);
            //progressBar.Visibility = ViewStates.Gone;

            // TODO:: Uncomment the following code when using a mobile service

            // Create ProgressFilter to handle busy state
            //var progressHandler = new ProgressHandler ();
            //progressHandler.BusyStateChange += (busy) => {
            //if (progressBar != null) 
            //progressBar.Visibility = busy ? ViewStates.Visible : ViewStates.Gone;
            //};
            try
            {
                //TODO::Uncomment the following code to create the mobile services client

                CurrentPlatform.Init();
                // Create the Mobile Service Client instance, using the provided
                // Mobile Service URL and key
                client = new MobileServiceClient(
                    Constants.ApplicationURL,
                    Constants.ApplicationKey);

                // Get the Mobile Service Table instance to use
                categoryTable = client.GetTable<Category>();

                //textNewTodo = FindViewById<EditText>(Resource.Id.textNewToDo);

                // Create an adapter to bind the items with the view



                // Load the items from the Mobile Service
                await RefreshItemsFromTableAsync();

            }
            catch (Java.Net.MalformedURLException)
            {
                CreateAndShowDialog(new Exception("There was an error creating the Mobile Service. Verify the URL"), "Error");
            }
            catch (Exception e)
            {
                CreateAndShowDialog(e, "Error");
            }
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

        public void OnItemClick(AdapterView parent, View view, int position, long id)
        {
            var intent = new Intent(this, typeof(StoryActivity));
            intent.PutExtra("selectedItemId", Convert.ToInt32(id));
            StartActivity(intent);            
        }

        // Initializes the activity menu
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.activity_main, menu);
            return true;
        }

        // Select an option from the menu
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId == Resource.Id.menu_refresh)
            {
                OnRefreshItemsSelected();
            }
            return true;
        }

        // Called when the refresh menu opion is selected
        async void OnRefreshItemsSelected()
        {
            await RefreshItemsFromTableAsync();
        }

        // Refresh the list with the items in the Mobile Service Table
        async Task RefreshItemsFromTableAsync()
        {
            // TODO:: Uncomment the following code when using a mobile service
            try
            {
                // Get the items that weren't marked as completed and add them in the adapter
                categoryItemList = await categoryTable.Where(item => item.FKMainCategoryId != null).ToListAsync();
                adapter.Clear();

                foreach (Category current in categoryItemList)
                    adapter.Add(current);
            }
            catch (Exception e)
            {
                CreateAndShowDialog(e, "Error");
            }


            // TODO:: Comment out these lines to remove the in-memory list
            //adapter.Clear();
            //foreach (var item in categoryItemList)
            //{
            //    if (item.CategoryName == null)
            //        adapter.Add(item);
            //}
            // NOTE:: End of lines to comment out
        }

        public async Task CheckItem(Category item)
        {
            // Set the item as completed and update it in the table
            item.CategoryName = null;

            // TODO:: Uncomment the following code when using a mobile service

            try
            {
                await categoryTable.UpdateAsync(item);
                if (item.CategoryName == null);
                    //adapter.Remove(item);
            }
            catch (Exception e)
            {
                CreateAndShowDialog(e, "Error");
            }


            // TODO:: Comment out these lines to remove the in-memory list
            categoryItemList.Add(item);
            if (item.CategoryName == null);
                //adapter.Remove(item);
            // NOTE:: End of lines to comment out
        }

        [Java.Interop.Export()]
        public async void AddItem(View view)
        {
            // Create a new item
            var item = new Category()
            {
                //Text = textNewTodo.Text,
                //Complete = false
            };

            // TODO:: Uncomment the following code when using a mobile service

            try
            {
                // Insert the new item
                await categoryTable.InsertAsync(item);

                if (item.CategoryName == null);
                    //adapter.Add(item);
            }
            catch (Exception e)
            {
                CreateAndShowDialog(e, "Error");
            }


            // TODO:: Comment out these lines to remove the in-memory list
            categoryItemList.Add(item);
            //adapter.Add(item);
            // NOTE:: End of lines to comment out

            //textNewTodo.Text = "";
        }

        void CreateAndShowDialog(Exception exception, String title)
        {
            CreateAndShowDialog(exception.Message, title);
        }

        void CreateAndShowDialog(string message, string title)
        {
            AlertDialog.Builder builder = new AlertDialog.Builder(this);

            builder.SetMessage(message);
            builder.SetTitle(title);
            builder.Create().Show();
        }

        // TODO:: Uncomment the following code when using a mobile service

        class ProgressHandler : DelegatingHandler
        {
            int busyCount = 0;

            public event Action<bool> BusyStateChange;

            #region implemented abstract members of HttpMessageHandler

            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
            {
                //assumes always executes on UI thread
                if (busyCount++ == 0 && BusyStateChange != null)
                    BusyStateChange(true);

                var response = await base.SendAsync(request, cancellationToken);

                // assumes always executes on UI thread
                if (--busyCount == 0 && BusyStateChange != null)
                    BusyStateChange(false);

                return response;
            }

            #endregion

        }

    }
}