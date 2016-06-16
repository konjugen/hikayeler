using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace storieService.DTO
{
    public class CategoryDto
    {
        public string Id { get; set; }
        public string CategoryName { get; set; }

        public string MainCategoryId { get; set; }

        public List<CategoryDto> subCategories { get; set; }

        public CategoryDto()
        {
            subCategories = new List<CategoryDto>();
        }
    }
}