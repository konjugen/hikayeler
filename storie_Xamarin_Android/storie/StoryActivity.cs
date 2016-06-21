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

namespace storie
{
    [Activity(Label = "StorieActivity")]
    public class StoryActivity : Activity, AdapterView.IOnItemClickListener
    {
        private MobileServiceClient client;
        private IMobileServiceTable<Story> storieTable;
        public List<Story> storieItemList = new List<Story>();
        public int selectedItem;

        private StoryItemAdapter adapter;
        private ListView listViewStorie, asd;

        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            selectedItem = Intent.Extras.GetInt("selectedItemId");
            selectedItem = selectedItem + 1;

            SetContentView(Resource.Layout.Activity_Stories);

            adapter = new StoryItemAdapter(this, Resource.Layout.Row_List_Storie);

            listViewStorie = FindViewById<ListView>(Resource.Id.listViewStorie);
            listViewStorie.OnItemClickListener = this;

            listViewStorie.Adapter = adapter;

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
                storieItemList = await storieTable.Where(item => item.Id == selectedItem.ToString()).ToListAsync();

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
            throw new NotImplementedException();
        }
    }
}