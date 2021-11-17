using ASP.NET_Core_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Project.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            if (Car.listOfCars.Count < 1)
                Car.GenerateCars();
            if (Owner.listOfOwners.Count < 1)
                Owner.GenerateOwners();

            return View();
        }
        public IActionResult Cars()
        {
            Car model = new Car();
            return View(model);
        }
        public IActionResult Owners()
        {
            Owner model = new Owner();
            return View(model);
        }
        public IActionResult ListAllCarsAndOwners()
        {
            CarOwnerViewModel vm = new CarOwnerViewModel();

            vm.Cars = Car.listOfCars;
            vm.Owners = Owner.listOfOwners; 
            return View(vm); 
        }


    }
}
