using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CoreTechnology.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProductRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        public IEnumerable<Product> Products =>
            _applicationDbContext.Products.Include(c => c.Category);

        public IEnumerable<Product> ProductOfTheWeek =>
            _applicationDbContext.Products.Include(c => c.Category)
                .Where(p => p.IsProductOfTheWeek);



        public Product GetProductById(int productId) =>
            _applicationDbContext.Products.FirstOrDefault(p => p.ProductId == productId);

    }
}
