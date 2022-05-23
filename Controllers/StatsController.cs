using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCoffe.Models;

namespace WebCoffe.Controllers
{
    public class StatsController : Controller
    {
        web_coffeeDbContext bazaPodataka = new web_coffeeDbContext();
        // GET: Stats
        public ActionResult Index()
        {
            var narudzbe = bazaPodataka.PopisNarudzbi.ToList();

            return View(narudzbe);
        }
    }
}