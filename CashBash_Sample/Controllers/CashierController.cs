using CashBash_Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CashBash_Sample.Controllers
{
    public class CashierController : Controller
    {
        // GET: Cashier
        public ActionResult Index()
        {
            List<MenuList> lst = new List<MenuList>();
            MenuList men = new MenuList();
            men.ActionName = "Cashier";
            men.Name = "Reprint draw receipt";
            lst.Add(men);

            ViewBag.controller = "Cashier";
            ViewBag.v = lst;
            ViewBag.Menu = lst;
            return View();
        }
    }
}