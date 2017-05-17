using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreTechnology.Models;
using CoreTechnology.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreTechnology.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        //public ViewResult List()
        //{
        //    ProductsListViewModel productsListViewModel = new ProductsListViewModel();
        //    productsListViewModel.Products = _productRepository.Products;

        //    productsListViewModel.CurrentCategory = "Laptops";
        //    return View(productsListViewModel);
        //}

        public ViewResult List(string category)
        {
            IEnumerable<Product> products;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.Products.OrderBy(p => p.ProductId);
                currentCategory = "All products";
            }
            else
            {
                products = _productRepository.Products.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ProductId);
                currentCategory = _categoryRepository.Categories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }

            return View(new ProductsListViewModel()
            {
                Products = products,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}
