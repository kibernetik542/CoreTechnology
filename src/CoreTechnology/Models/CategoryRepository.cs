using System.Collections.Generic;

namespace CoreTechnology.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        public IEnumerable<Category> Categories => _applicationDbContext.Categories;
    }
}
