using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            //var customers = GetCustomers();
            //return View(customers);
            return Content("tekst");
        }

        public ActionResult Details(int id)
        {
            return Content("tekst en id="+ id);
        }
    }
}