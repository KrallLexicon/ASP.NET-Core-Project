using ASP.NET_Core_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Project.Controllers
{
    public class TestingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TestView()
        {
            return View(); 
        }

        public IActionResult Person()
        {
            ViewBag.Message = PersonModel.WriteMessage();
            return View(); 
        }
        [HttpPost]
        public IActionResult Person(string name, int age)
        {
            HttpContext.Session.SetString("Name", name); 
            PersonModel pm = new PersonModel();
            pm.Name = name;
            pm.Age = age;

            ViewBag.Message = pm.CheckAge(age);
            return View();
        }

        public IActionResult SetSession()
        {            
            HttpContext.Session.SetString("TestSession", "This is a test!");           
            return View();
        }
        public IActionResult GetSession()
        {
            ViewBag.SessionMessage = HttpContext.Session.GetString("TestSession");
            return View(); 
        }
    }
}
