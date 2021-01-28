using YemekSiparisi_IntroNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YemekSiparisi_IntroNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Hour = DateTime.Now.Hour;

            List<Product> products = new List<Product>();
            products.Add(new Product { Name = "Pizza", Price = 20 });
            products.Add(new Product { Name = "Hamburger", Price = 20 });
            products.Add(new Product { Name = "Dürüm", Price = 17 });
            products.Add(new Product { Name = "Tavuk Şiş", Price = 19 });


            //ViewBag.Products = products;

            return View(products);
        }

        public IActionResult Siparis()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Siparis(KullaniciGirisi kullaniciGirisi)
        {
            if (ModelState.IsValid)
            {
                if (kullaniciGirisi.IsAccepted)
                {
                    AlinanSiparisler.Add(kullaniciGirisi);
                }
                // TODO 1: Her şey doğruysa bu kısım çalışacak....
                return View("Tesekkur", kullaniciGirisi);

            }
            return View();
        }

     
    }
}
