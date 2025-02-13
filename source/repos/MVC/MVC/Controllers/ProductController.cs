using Microsoft.AspNetCore.Mvc;
using MVC.Models;
namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> l = new List<Product>();
            l.Add(new Product { Id = 1, Name = "Product 1", Price = 100 });
            l.Add(new Product { Id = 2, Name = "Product 2", Price = 200 });
            return View(l);
        }
    }
}
