using CashBash_Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CashBash_Sample.Controllers
{
    public class CheckInController : Controller
    {
        public ActionResult Index()
        {
            List<MenuList> lst = new List<MenuList>();
            MenuList men = new MenuList();
            men.ActionName = "CheckIn";
            men.Name = "Check Balances";
            lst.Add(men); 

            ViewBag.controller = "Check In";
            ViewBag.v = lst;
            ViewBag.Menu = lst;
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