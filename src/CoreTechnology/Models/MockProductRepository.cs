using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTechnology.Models
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();


        public IEnumerable<Product> Products => new List<Product>
        {
            new Product
            {
                ProductId = 1,
                Name = "Apple MacbookPro",
                Price = 1200.76M,ShortDescription = "Lorem ipsum",
                LongDescription = "---",
                Category = _categoryRepository.Categories.ToList()[0],
                ImageUrl = "https://www.noelleeming.co.nz/shop/renderImage.image?imageName=products%2F149%2F149658.1.jpg&padding=0",
                InStock = true, IsProductOfTheWeek = false,
                ImageThumbnailUrl = "http://www.ipoint.kz/uploads/images/8e1c91b02fbe_small.jpg"
            },
            new Product
            {
                ProductId = 2,
                Name = "iPhone 7",
                Price = 900.76M,
                ShortDescription = "Lorem ipsum",
                LongDescription = "---",
                Category = _categoryRepository.Categories.ToList()[1],
                ImageUrl = "http://theskop.com/wp-content/uploads/2016/10/iPhone-7-Jet-Black-dan-Black.jpg",
                InStock = true, IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://gidapple.ru/wp-content/cache/thumb/6362d8710_320x200.jpg"

            },
            new Product
            {
                ProductId = 3,
                Name = "LG 4k TV",
                Price = 1500.76M,
                ShortDescription = "Lorem ipsum",
                LongDescription = "---",
                Category = _categoryRepository.Categories.ToList()[2],
                ImageUrl = "http://holod.ru/pics/clean/big/65/473865_0.jpg",
                InStock = true, IsProductOfTheWeek = false,
                ImageThumbnailUrl = "http://www.diggita.it/modules/auto_thumb/2016/12/18/1571818_lg-tv-oled-55EG960V_thumb.jpg"
            },
            new Product
            {
                ProductId = 4,
                Name = "Asus Predator",
                Price = 1750.76M,
                ShortDescription = "Lorem ipsum",
                LongDescription = "---",
                Category = _categoryRepository.Categories.ToList()[0],
                ImageUrl = "https://dstatic.computeruniverse.net/images/1000/9062932790123713915145A684656309.jpg",
                InStock = true, IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://2.bp.blogspot.com/-0OWJUkN6EgE/WHUidDFoNzI/AAAAAAAAd_4/KH0a1Vw9uVUGfAZU3YtBMARkNa5fPqpbgCLcB/s320/Asus%2BGaming%2BLaptop213.jpg"
            },
        };


        public IEnumerable<Product> ProductOfTheWeek { get; }
        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
