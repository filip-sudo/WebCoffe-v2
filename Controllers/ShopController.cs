using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCoffe.Models;

namespace WebCoffe.Controllers
{
    
    public class ShopController : Controller
    {
        web_coffeeDbContext bazaPodataka = new web_coffeeDbContext();   
        // GET: Shop
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DodajNarudzbu(Narudzba n)
        {
            bazaPodataka.PopisNarudzbi.Add(n);

            bazaPodataka.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}