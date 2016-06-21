using Microsoft.WindowsAzure.Mobile.Service;
using storieService.DataObjects;
using storieService.DTO;
using storieService.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Controllers;

namespace storieService.Controllers
{
    public class CategoryController : TableController<Category>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            storieContext context = new storieContext();
            DomainManager = new EntityDomainManager<Category>(context, Request, Services);
        }

        //public List<CategoryDto> GetCategories()
        //{
        //    IQueryable<Category> categoryQueryable = Query();


        //    var list = categoryQueryable.ToList();

        //    var categories = categoryQueryable.Where(p => string.IsNullOrEmpty(p.FKMainCategoryId)).Select(p => new CategoryDto
        //    {
        //        Id = p.Id,
        //        CategoryName = p.CategoryName
        //    }).ToList();

        //    foreach(var item in categories)
        //    {
        //        var subCategories = categoryQueryable.Where(p => p.FKMainCategoryId == item.Id).Select(p=> new CategoryDto()
        //        {
        //            Id = p.FKMainCategoryId,
        //            CategoryName = p.CategoryName
        //        }).ToList();
        //        item.subCategories.AddRange(subCategories);
        // }
        //    return categories;
        //}

        public IQueryable<Category> GetAllCategoryItems()
        {
            return Query();
        }

    }
}
