using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var list = new List<Student>();
            var student = new Student
            {
                StudentId = 1,
                StudentName = "jack",
                Age = 12
            };

            list.Add(student);
            return View(student);
        }

        public void List<T>(T t)
        {

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