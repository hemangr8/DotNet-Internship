using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAssignment.Models;

namespace MVCAssignment.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Student()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Student(StudentModel obj)
        {
            ViewBag.Msg = "The Student " + obj.Name + " with Roll No. :" + obj.RollNo + " and Class :" + obj.Class + " was added";
            return View();
        }
    }
}