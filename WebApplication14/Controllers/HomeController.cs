using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication14.Models;
using WebApplication14.Interfaces;
namespace WebApplication14.Controllers
{
    public class HomeController : Controller
    {
        IValueCalculator calc = null;
        private Product[] products = {
            new Product {Name = "Каяк", Category = "Водные виды спорта", Price = 275M},
            new Product {Name = "Спасательный жилет", Category = "Водные виды спорта", Price = 48.95M},
            new Product {Name = "Мяч", Category = "Футбол", Price = 19.50M},
            new Product {Name = "Угловой флажок", Category = "Футбол", Price = 34.95M}
        };
        public HomeController(IValueCalculator calc)
        {
            this.calc = calc;
        }
        public ActionResult Index()
        {
           
            ShoppingCart cart = new ShoppingCart(calc) { Products = products };
            decimal totalValue = cart.CalculateProductTotal();
            ViewBag.totalValue = totalValue;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}