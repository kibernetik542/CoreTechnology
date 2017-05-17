using CoreTechnology.Models;
using CoreTechnology.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreTechnology.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProductsOfTheWeek = _productRepository.ProductOfTheWeek
            };


            return View(homeViewModel);
        }
    }
}
