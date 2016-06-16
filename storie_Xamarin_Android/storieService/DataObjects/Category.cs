using Microsoft.WindowsAzure.Mobile.Service;
using Microsoft.WindowsAzure.Mobile.Service.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace storieService.DataObjects
{
    public class Category : EntityData
    {
        public string CategoryName { get; set; }
        public string FKMainCategoryId { get; set; }
    }
}