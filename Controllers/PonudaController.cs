using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCoffe.Models;

namespace WebCoffe.Controllers
{
    public class PonudaController : Controller
    {
        web_coffeeDbContext bazaPodataka = new web_coffeeDbContext(); 
        // GET: Ponuda
        public ActionResult Index()
        {
            var kave = bazaPodataka.PopisKave.ToList();

            return View(kave);
        }
    }
}