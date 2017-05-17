using System.Collections.Generic;
using CoreTechnology.Models;

namespace CoreTechnology.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> ProductsOfTheWeek { get; set; }
    }
}
