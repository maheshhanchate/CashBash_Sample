using CashBash_Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CashBash_Sample.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports
        public ActionResult Index()
        {
            List<MenuList> lst = new List<MenuList>();
            MenuList men = new MenuList();
            men.ActionName = "Reports";
            men.Name = "Select Report";
            lst.Add(men); 

            ViewBag.controller = "Reports";
            ViewBag.v = lst;
            ViewBag.Menu = lst;
            return View();
        }
    }
}