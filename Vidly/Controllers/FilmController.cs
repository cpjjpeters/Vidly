using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class FilmController : Controller
    {
        // GET: Film
        public ActionResult Projectie()
        {
            var film = new Film() { Name = "E.T.", Author = "Steven Spielberg" };
            return View(film);
        }
    }
}