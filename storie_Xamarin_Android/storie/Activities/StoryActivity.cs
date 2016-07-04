using System;
using Android.OS;
using Android.App;
using Android.Views;
using Android.Widget;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using System.Collections.Generic;
using storie;
using XamarinTodoQuickStart;
using Android.Content;
using Android.Support.V7.Widget;

namespace storie
{
    [Activity(Label = "StorieActivity")]
    public class StoryActivity : Activity, AdapterView.IOnItemClickListener
    {
        private MobileServiceClient client;
        private IMobileServiceTable<Story> storieTable;
        public List<Story> storieItemList = new List<Story>();
        public string selectedItem;

        private StoryAdapter adapter;
        private RecyclerView listViewStory;

        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            selectedItem = Intent.Extras.GetString("selectedCategoryId");
           
            SetContentView(Resource.Layout.Activity_Story);

            adapter = new StoryAdapter(this, FindViewById<RecyclerView>(Resource.Id.listViewStory));

            listViewStory = (RecyclerView)FindViewById(Resource.Id.listViewStory);

            listViewStory.SetLayoutManager(new LinearLayoutManager(this));

            listViewStory.SetAdapter(adapter);


            //adapter = new StoryItemAdapter(this, Resource.Layout.Row_List_Story);
            //listViewStory = FindViewById<ListView>(Resource.Id.listViewStory);
            //listViewStory.OnItemClickListener = this;
            //listViewStory.Adapter = adapter;

            CurrentPlatform.Init();

            client = new MobileServiceClient(
                Constants.ApplicationURL,
                Constants.ApplicationKey);

            storieTable = client.GetTable<Story>();

            await RefreshItemsFromTableAsync();
        }

        async Task RefreshItemsFromTableAsync()
        {
            try
            {
                // Get the items that weren't marked as completed and add them in the adapter
                storieItemList = await storieTable.Where(item => item.FkMainCategoryId == selectedItem.ToString()).ToListAsync();

                adapter.Clear();

                foreach (Story current in storieItemList)
                    adapter.Add(current);
            }
            catch (Exception e)
            {
                CreateAndShowDialog(e, "Error");
            }
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

        public void OnItemClick(AdapterView parent, View view, int position, long id)
        {
            var bundle = new Bundle();
            var contentList = new List<string>();
            var titleList = new List<string>();
            var intent = new Intent(this, typeof(ContentActivity));

            foreach (var current in storieItemList)
            {
                contentList.Add(current.Content);
                titleList.Add(current.Title);
                bundle.PutStringArrayList("selectedStorieContent", contentList);
                bundle.PutStringArrayList("selectedStorieTitle", titleList);
            }

            intent.PutExtra("selectedStorieId", Convert.ToInt32(id));
            intent.PutExtras(bundle);

            StartActivity(intent);
        }

        //[Java.Interop.Export()]
        //public async void AddItem(View view)
        //{
        //    if (client == null || string.IsNullOrWhiteSpace(addStorieText.Text))
        //    {
        //        return;
        //    }

        //    // Create a new item
        //    var item = new Story
        //    {
        //        Id = "",
        //        Title = "",
        //        Content = addStorieText.Text,
        //        FkMainCategoryId = ""               
        //    };

        //    try
        //    {
        //        await storieTable.InsertAsync(item); // insert the new item into the local database
        //        //await SyncAsync(); // send changes to the mobile service

        //        //if (!item.Complete)
        //        //{
        //        //    adapter.Add(item);
        //        //}
        //    }
        //    catch (Exception e)
        //    {
        //        CreateAndShowDialog(e, "Error");
        //    }

        //    addStorieText.Text = "";
        //}
    }
}