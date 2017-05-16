using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTechnology.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories => new List<Category>
        {
            new Category {CategoryId = 1,CategoryName = "Laptops",Description = "For Gaming or for business"},
            new Category {CategoryId = 2,CategoryName = "Phones",Description = "The world must have devices"},
            new Category {CategoryId = 3,CategoryName = "TVs",Description = "Change your vision"}
        };
    }
}
