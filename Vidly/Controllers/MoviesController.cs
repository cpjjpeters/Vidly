using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek!"
            };
            var custormers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = custormers
            };

            return View(viewModel);  //return View(movie);
            //return new ViewResult();
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

        }
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(month + "/" + year);
        }
        public ActionResult Rondam()
        {
            var movie = new Movie() { Name = "Batman Returns." };
            ViewData["Movie"] = movie;
            return View();
        }
        //public ActionResult Rindim()
        //{
        //    var movie = new Movie() {Name = "Chocolat"};
        //    var viewResult = new ViewResult();
        //    viewResult.ViewData.Model
        //    return View();
        //}
    }
}