using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCoffe.Models;
using WebCoffe.Reports;

namespace WebCoffe.Controllers
{
    public class PonudaController : Controller
    {
        web_coffeeDbContext bazaPodataka = new web_coffeeDbContext(); 
        // GET: Ponuda
        [AllowAnonymous]
        public ActionResult Index()
        {
            var kave = bazaPodataka.PopisKave.ToList();

            return View(kave);
        }

        [AllowAnonymous]
        public ActionResult IspisKave(string naziv, string sort)
        {
            var kava = bazaPodataka.PopisKave.ToList();

            if (!String.IsNullOrWhiteSpace(naziv))
                kava = kava.Where(x => x.Naziv.ToUpper().Contains(naziv.ToUpper())).ToList();

            switch (sort)
            {
                case "naziv_desc":
                    kava = kava.OrderByDescending(s => s.Naziv).ToList();
                    break;

                case "naziv":
                    kava = kava.OrderBy(s => s.Naziv).ToList();
                    break;
            }

            PonudaReport ponudaReport = new PonudaReport();
            ponudaReport.ListaKave(kava);

            return File(ponudaReport.Podaci, System.Net.Mime.MediaTypeNames.Application.Pdf, "PopisKave.pdf");
        }
    }
}