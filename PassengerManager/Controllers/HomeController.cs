using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PassengerManager.Models;


namespace PassengerManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Passenger.GetAll());
        }

        public IActionResult Create(string FirstName, string LastName, string PhoneNumber)
        {
            Passenger.Create(FirstName, LastName, PhoneNumber);
            return RedirectToAction("Index");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}