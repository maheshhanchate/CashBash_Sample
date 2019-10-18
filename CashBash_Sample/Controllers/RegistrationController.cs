using CashBash_Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CashBash_Sample.Controllers
{
    public class RegistrationController : Controller
    {
        public ActionResult SearchRegistration()
        {
            FillData();
            return View();
        }
        public void FillData()
        {
            List<MenuList> lst = new List<MenuList>();
            MenuList men = new MenuList();
            //men.ActionName = "Registration";
            //men.Name = "Registration";
            //lst.Add(men);

            men = new MenuList();
            men.ActionName = "SearchRegistration";
            men.Name = "Search";
            lst.Add(men);


            men = new MenuList();
            men.ActionName = "AddJMA";
            men.Name = "Add JM&A Staff";
            lst.Add(men);

            men = new MenuList();
            men.ActionName = "AddWinner";
            men.Name = "Add Winner";

            lst.Add(men);
            men = new MenuList();
            men.ActionName = "DealerPullKept";
            men.Name = "Dealer Pull Kept";
            lst.Add(men);

            men = new MenuList();
            men.ActionName = "DealerPullOrder";
            men.Name = "Dealer Pull Order";
            lst.Add(men);

            ViewBag.controller = "Registration";
            ViewBag.v = lst;
            ViewBag.Menu = lst;
        }
        public ActionResult Search()
        {
            FillData();

            return View();
        }
        public ActionResult AddJMA()
        {
            FillData();

            return View();
        }
        public ActionResult AddWinner()
        {
            FillData();

            return View();
        }

        public ActionResult DealerPullOrder()
        {
            FillData();

            return View();
        }
        public ActionResult DealerPullKept()
        {
            FillData();

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