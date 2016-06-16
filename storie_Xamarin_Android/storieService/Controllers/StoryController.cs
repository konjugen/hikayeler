using Microsoft.WindowsAzure.Mobile.Service;
using storieService.DataObjects;
using storieService.DTO;
using storieService.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Controllers;

namespace storieService.Controllers
{
    public class StoryController : TableController<Story>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            storieContext context = new storieContext();
            DomainManager = new EntityDomainManager<Story>(context, Request, Services);
        }
    
        public List<StoryDto> GetStoriesByCategoryId(string categoryId)
        {
            IQueryable<Story> categoryQueryable = Query();

            var stories = categoryQueryable.Where(p => p.FkMainCategoryId == categoryId).Select(p =>
                 new StoryDto()
                 {
                     Id = p.Id,
                     Content = p.Content,
                     Title = p.Title
                 }
                ).ToList();
            return stories;
        }
    }
}
