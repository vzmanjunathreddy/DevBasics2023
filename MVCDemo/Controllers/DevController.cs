using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class DevController : Controller
    {
        // GET: Dev
        public ActionResult Welcome(int? id, string name)
        {
            return View();
        }

        public ActionResult StudentData()
        {
            //Model to the view 
            // ViewBag,ViewData
            //ViewBag is of Dynamic Property type which holds values and passes it to the view from controller
            // it used to pass tempoerory data from Controller to view

            List<string> listofStudents = new List<string>() { "Sachin", "Virat", "Yuvi" };
            ViewBag.Students = listofStudents;
            ViewBag.Welcomestring = "Welcome to MVC Programing";
            ViewBag.CountOfStudents = listofStudents.Count();

            return View();
        }
        [HttpGet]
        public ActionResult HTMLHelpersDemo()
        {

            return View();
        }

        [HttpPost]
        public ContentResult HTMLHelpersDemoPost()
        {

            return Content(
                "User Name is = " + Request.Form["firstname"] + "," + Request.Form["lastname"] + "<br/>" +
                "Email ID  = " + Request.Form["email"] + "<br/>" +
                "Gender    = " + Request.Form["Gender"] + "<br/>" +
                "Courses   = " + Request.Form.GetValues("Salesforce")[0] + " " + Request.Form.GetValues("Angularjs")[0] + " " + Request.Form.GetValues("Reactjs")[0] + " " + Request.Form.GetValues("Azure")[0] + "<br/>" +
                "Contact   = " + Request.Form["contact"] + "<br/>" +
                 "My Areas of Interest is   = " + Request.Form["areaofInterest"] + "<br/>"
                );
        }
    }


}
