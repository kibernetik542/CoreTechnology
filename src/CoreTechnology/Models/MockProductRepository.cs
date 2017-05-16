using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTechnology.Models
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();


        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product {ProductId = 1,Name = "Apple MacbookPro",Price = 1200.76M,ShortDescription = }
                };
            }
        }



        public IEnumerable<Product> ProductOfTheWeek { get; }
        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
