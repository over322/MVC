using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly CreditContext db = new CreditContext();

        public ActionResult Index()
        {
            GiveCredits();
            return View();
        }

        [Authorize]
        [HttpGet]
        public ActionResult CreateBid()
        {
            GiveCredits();
            var allBids = db.Bids.ToList();
            ViewBag.Bids = allBids;

            return View();
        }

        [HttpPost]
        public string CreateBid(Bid newBid)
        {
            newBid.bidDate = DateTime.Now;
            // Добавляем новую заявку в БД
            db.Bids.Add(newBid);
            // Сохраняем в БД все изменения
            db.SaveChanges();
            return "Спасибо, <b>" + newBid.Name +
                   "</b>, за выбор нашего банка. Ваша заявка будет рассмотрена в течении 10 дней.";
        }

        private void GiveCredits()
        {
            var allCredits = db.Credits.ToList();
            ViewBag.Credits = allCredits;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            IList<string> roles = new List<string> { "Роль не определена" };
            var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = userManager.FindByEmail(User.Identity.Name);
            if (user != null)
                roles = userManager.GetRoles(user.Id);
            ViewBag.rol = roles;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult BidSearch(string name)
        {
            var allBids = db.Bids.Where(a =>
                a.CreditHead.Contains(name)).ToList();
            if (allBids.Count == 0)
                return Content("Указанный кредит " + name + " не найден");
            //return HttpNotFound();
            return PartialView(allBids);
        }
    }
}