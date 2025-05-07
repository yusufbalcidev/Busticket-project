using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusTicketSoftito.Controllers
{
    public class TicketController : Controller
    {
        TicketManager ticketManager = new TicketManager(new EfTicketDal());

        public ActionResult Index()
        {
            var values = ticketManager.TicketList().Where(x=>x.IsDeleted == false).ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult DeleteTicket(int id) {
            var ticket = ticketManager.GetById(id);
            ticket.IsDeleted = true;
            ticketManager.TicketUpdate(ticket);
            return RedirectToAction("Index", "Ticket");

        }
    }
}