using MyApp.Models;
using System.Linq;
using System.Web.Mvc;

namespace MyApp.Controllers
{
    public class HomeController : Controller
    {
        private MyAppContext db = new MyAppContext();
        public ActionResult Index()
        {
            var allProducts = db.Products.ToList<Product>();
            ViewBag.Products = allProducts;
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