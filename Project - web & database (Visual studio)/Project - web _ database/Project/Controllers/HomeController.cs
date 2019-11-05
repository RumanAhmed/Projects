using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Reliable Rentals.";

            return View();
        }

        public ActionResult Cars()
        {
            ViewBag.Message = "Our cars";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult VW()
        {
            

            return View();
        }

        public ActionResult Porsche()
        {
            return View();
        }

        public ActionResult Merc()
        {
            return View();
        }

        public ActionResult OneDay()
        {
            return View();
        }

        public ActionResult TwoDay()
        {
            return View();
        }

        public ActionResult OneWeek()
        {
            return View();
        }

        public ActionResult TwoWeek()
        {
            return View();
        }

        public ActionResult RentTwoWeek()
        {
            myDbEntitiesComplete myDbEntitiesComplete = new myDbEntitiesComplete();
            var getvehiclelist = myDbEntitiesComplete.Vehicles.ToList();
            SelectList list = new SelectList(getvehiclelist, "Id", "Make");
            ViewBag.vehiclelistname = list;
            return View();
        }

        public ActionResult RentOwoWeek()
        {
            myDbEntitiesComplete myDbEntitiesComplete = new myDbEntitiesComplete();
            var getvehiclelist = myDbEntitiesComplete.Vehicles.ToList();
            SelectList list = new SelectList(getvehiclelist, "Id", "Make");
            ViewBag.vehiclelistname = list;
            return View();
        }

        public ActionResult RentTwoDay()

        {
            myDbEntitiesComplete myDbEntitiesComplete = new myDbEntitiesComplete();
            var getvehiclelist = myDbEntitiesComplete.Vehicles.ToList();
            SelectList list = new SelectList(getvehiclelist, "Id", "Make");
            ViewBag.vehiclelistname = list;
            return View();
         
            
        }

        public ActionResult RentOneDay()
        {

            myDbEntitiesComplete myDbEntitiesComplete = new myDbEntitiesComplete();
            var getvehiclelist = myDbEntitiesComplete.Vehicles.ToList();
            SelectList list = new SelectList(getvehiclelist, "Id", "Make");
            ViewBag.vehiclelistname = list;
            return View();
        }

        public string RntOne(CustomerModel e)
        {
            return "BOOKED FOR 1 DAY."+ " " + "PRICE = £30 "+ " " + "YOUR DETAILS --->" +"First Name:" + e.F_name + "|"+ "Last Name:" + e.L_name + "|" + "Company Name:" + e.Company_name + "|" + "Address:" + e.Address + "|" + "Licesne:" + e.Drivers_license_no + "|" + "Phone number:" + e.Phone_number;

        }

        public string RntTwo(CustomerModel e)
        {
            
            return "BOOKED FOR 2 DAYS." + " " + "PRICE = £60 " + " " + "YOUR DETAILS --->" + "First Name:" + e.F_name + "|" + "Last Name:" + e.L_name + "|" + "Company Name:" + e.Company_name + "|" + "Address:" + e.Address + "|" + "Licesne:" + e.Drivers_license_no + "|" + "Phone number:" + e.Phone_number;

        }

        public string RntOneW(CustomerModel e)
        {
            return "BOOKED FOR 1 WEEK." + " " + "PRICE = £210 " + " " + "YOUR DETAILS --->" + "First Name:" + e.F_name + "|" + "Last Name:" + e.L_name + "|" + "Company Name:" + e.Company_name + "|" + "Address:" + e.Address + "|" + "Licesne:" + e.Drivers_license_no + "|" + "Phone number:" + e.Phone_number;

        }

        public string RntTwoW(CustomerModel e)
        {
            return "BOOKED FOR 2 WEEKS." + " " + "PRICE = £420 " + " " + "YOUR DETAILS --->" + "First Name:" + e.F_name + "|" + "Last Name:" + e.L_name + "|" + "Company Name:" + e.Company_name + "|" + "Address:" + e.Address + "|" + "Licesne:" + e.Drivers_license_no + "|" + "Phone number:" + e.Phone_number;

        }




        public ActionResult Details(int submitId)
        {
            return View("Cars");

        }





    }
}