using AVisit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AVisit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home1()
        {
            return View();
        }
        public ActionResult Index()
        {
            Home_location_Manager dropdownmanager = new Home_location_Manager();
            List<location> sp = dropdownmanager.DropDownName();
            SelectList selectListItems = new SelectList(sp, "Location", "Location");

            ViewBag.DropdownList = selectListItems;
            return View();

            //return View("~/Views/Home/Index.cshtml",sp);
        
        }
        [HttpPost]
        public ActionResult Index(Home_location_model home_Location_Model)
        {

            

            return View();

            //return View("~/Views/Home/Index.cshtml",sp);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            
            return View();
        }
       

    }
}