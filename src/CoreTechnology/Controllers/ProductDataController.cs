using System.Collections.Generic;
using System.Linq;
using CoreTechnology.Models;
using CoreTechnology.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreTechnology.Controllers
{
    [Route("api/[controller]")]
    public class ProductDataController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductDataController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IEnumerable<ProductViewModel> LoadMoreProducts()
        {
            IEnumerable<Product> dbProducts = null;

            dbProducts = _productRepository.Products.OrderBy(p => p.ProductId).Take(9);

            List<ProductViewModel> products = new List<ProductViewModel>();

            foreach (var dbProduct in dbProducts)
            {
                products.Add(MapDbProdToProdViewModel(dbProduct));
            }
            return products;
        }

        private ProductViewModel MapDbProdToProdViewModel(Product dbProduct) => new ProductViewModel()
        {
            ProductId = dbProduct.ProductId,
            Name = dbProduct.Name,
            Price = dbProduct.Price,
            ShortDescription = dbProduct.ShortDescription,
            ImageThumbnailUrl = dbProduct.ImageThumbnailUrl
        };
    }
}
