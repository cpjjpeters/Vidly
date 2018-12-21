using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class KlantController : Controller
    {
        // GET: Klant
        public ActionResult Index()
        {
            
            var klant1 = new Klant() { ID=1,Naam = "Bollemans" };
            var klant2 = new Klant() { ID = 2, Naam = "Ceulemans" };
            return View(klant1);
        }
    }
}