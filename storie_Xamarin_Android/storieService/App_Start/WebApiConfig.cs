using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;
using Microsoft.WindowsAzure.Mobile.Service;
using storieService.DataObjects;
using storieService.Models;

namespace storieService
{
    public static class WebApiConfig
    {
        public static void Register()
        {

                     // Use this class to set configuration options for your mobile service
            ConfigOptions options = new ConfigOptions();

            // Use this class to set WebAPI configuration options
            HttpConfiguration config = ServiceConfig.Initialize(new ConfigBuilder(options));

            // To display errors in the browser during development, uncomment the following
            // line. Comment it out again when you deploy your service for production use.
            // config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;

            // Set default and null value handling to "Include" for Json Serializer
            config.Formatters.JsonFormatter.SerializerSettings.DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Include;
            config.Formatters.JsonFormatter.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Include;

            //Database.SetInitializer(new storieInitializer());

        }
    }

    public class storieInitializer : ClearDatabaseSchemaIfModelChanges<storieContext>
    {
        //protected override void Seed(storieContext context)
        //{
        //    List<Category> todoItems = new List<Category>
        //        {
        //            new Category { Id = Guid.NewGuid().ToString(), CategoryName = "First item", Deleted = false },
        //            new Category { Id = Guid.NewGuid().ToString(), CategoryName = "Second item", Deleted = false },
        //        };

        //    foreach (Category todoItem in todoItems)
        //    {
        //        context.Set<Category>().Add(todoItem);
        //    }

        //    base.Seed(context);
        //}
    }
}

