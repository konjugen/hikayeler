using Microsoft.WindowsAzure.Mobile.Service;

namespace storieService.DataObjects
{
    public class Story : EntityData
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string FkMainCategoryId { get; set; }
    }
}