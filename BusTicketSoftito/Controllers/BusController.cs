using BusinessLayer.Concrete;
using BusTicketSoftito.Methods;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.ApplicationServices;
using System.Web.Mvc;

namespace BusTicketSoftito.Controllers
{
    public class BusController : Controller
    {
        BusManager busManager = new BusManager(new EfBusDal());
        public ActionResult Index()
        {
            var values = busManager.BusList().Where(x => x.IsDeleted == false).ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult DeleteBus(int id)
        {
            var bus = busManager.GetById(id);
            bus.IsDeleted = true;
            busManager.BusUpdate(bus);
            return RedirectToAction("Index", "Bus");

        }
        [HttpGet]
        public ActionResult AddBus()
        {
            var bus = new Bus();
            bus.ImageUrl = "";
            return View(bus);
        }
        [HttpPost]
        public ActionResult AddBus(Bus bus, HttpPostedFileBase FileUrl)
        {

            if (FileUrl != null)
            {
                bus.ImageUrl = FileService.CreateFile(FileUrl);
            }
            else
            {
                bus.ImageUrl = "https://w0.peakpx.com/wallpaper/991/207/HD-wallpaper-scania-touring-bus-2019-passenger-bus-transportation-of-passengers-travel-by-bus-concepts-bus-on-the-road-scania.jpg";
            }

            busManager.BusInsert(bus);
            return RedirectToAction("Index", "Bus");
        }
        [HttpGet]
        public ActionResult EditBus(int id)
        {
            var bus = busManager.GetById(id);   
            return View(bus);
        }
        [HttpPost]
        public ActionResult EditBus(Bus bus, HttpPostedFileBase FileUrl)
        {
           
            if (FileUrl != null)
            {
                bus.ImageUrl = FileService.CreateFile(FileUrl);
            }
           
            busManager.BusUpdate(bus);
            return RedirectToAction("Index", "Bus");
        }
    }
}