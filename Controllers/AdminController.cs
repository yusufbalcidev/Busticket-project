using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace BusTicketSoftito.Controllers
{
    public class AdminController : Controller
    {
        BusManager busManager = new BusManager(new EfBusDal());
        TicketManager ticketManager = new TicketManager(new EfTicketDal());
        public ActionResult Index()
        {
            var otobusCount = busManager.BusList().Where(x => x.IsDeleted == false).ToList().Count;   
            var ticketCOunt = ticketManager.TicketList().Where(x => x.IsDeleted == false).ToList().Count;

            ViewBag.count1 = otobusCount;
            ViewBag.count2 = ticketCOunt;
            return View();
        }
        public ActionResult Logout()
        {
            TempData["Logout"] = "Siteden basariyla cikildi.";
            return RedirectToAction("Index", "Home");
        }
    }
}