using CashBash_Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CashBash_Sample.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult SearchUser()
        {
            FillMenu();
            return View();
        }
        public void FillMenu()
        {
            List<MenuList> lst = new List<MenuList>();
            MenuList men = new MenuList();
            men.ActionName = "SearchUser";
            men.Name = "Search User";
            lst.Add(men);

            men = new MenuList();
            men.ActionName = "AddUser";
            men.Name = "Add User";
            lst.Add(men);


            men = new MenuList();
            men.ActionName = "EditEvent";
            men.Name = "Edit Event";
            lst.Add(men);

            men = new MenuList();
            men.ActionName = "AddEditTitles";
            men.Name = "Add/Edit Titles";

            lst.Add(men);
            men = new MenuList();
            men.ActionName = "TravelPreferences";
            men.Name = "Travel Preferences";
            lst.Add(men); 

            men = new MenuList();
            men.ActionName = "EditCash";
            men.Name = "Edit cash";
            lst.Add(men);
            ViewBag.controller = "Admin";
            ViewBag.v = lst;
            ViewBag.Menu = lst;
        }
        public ActionResult AddUser()
        {
            FillMenu();
            return View();
        }
        public ActionResult EditEvent()
        {
            FillMenu();
            return View();
        }
        public ActionResult AddEditTitles()
        {
            FillMenu();
            return View();
        }
        public ActionResult TravelPreferences()
        {
            FillMenu();
            return View();
        }
        public ActionResult EditPullInfo()
        {
            FillMenu();
            return View();
        }
        public ActionResult EditCash()
        {
            FillMenu();
            return View();
        }

    }
}