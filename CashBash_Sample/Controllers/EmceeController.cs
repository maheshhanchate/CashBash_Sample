using CashBash_Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CashBash_Sample.Controllers
{
    public class EmceeController : Controller
    {
        // GET: Emcee
        public ActionResult Index()
        {
            List<MenuList> lst = new List<MenuList>();
            MenuList men = new MenuList();
            men.ActionName = "Emcee";
            men.Name = "Dealers Pull List";
            lst.Add(men); 
            ViewBag.controller = "Emcee";
            ViewBag.v = lst;
            ViewBag.Menu = lst;
            return View();
        }
    }
}