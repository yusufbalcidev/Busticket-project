using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusTicketSoftito.Controllers
{
    public class HomeController : Controller
    {
        TicketManager ticketManager = new TicketManager(new EfTicketDal());
        BusManager busManager = new BusManager(new EfBusDal());

        [HttpGet]
        public ActionResult Index()
        {
            var values = busManager.BusList().Where(x => x.IsDeleted == false).ToList();
            return View(values);
        }
        [HttpPost]
        public ActionResult Index(Ticket ticket)
        {
            if(ticket.From == ticket.To)
            {
                TempData["TicketError"] = "Nereden ve nereye bilgileri ayni olamaz.";
                return RedirectToAction("Index", "Home");
            }
            var checkValidation = ticketManager.TicketList().Where(x=>x.Seat == ticket.Seat && x.From == ticket.From && x.To == ticket.To && x.DateTime == ticket.DateTime).FirstOrDefault();
            if (checkValidation != null)
            {
                TempData["TicketError"] = "Bu koltuk zaten alinmis.";
                return RedirectToAction("Index", "Home");
            }
            ticketManager.TicketInsert(ticket);
            TempData["Success"] = "Biletiniz basariyla alindi.";
            return RedirectToAction("Index", "Home");   
        }


    }
}