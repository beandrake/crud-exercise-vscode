/*  
    the Controllers/HomeController.cs file is linked by default to:
      Views/Home/Index.cshtml and Models/Home.cs
    because of the shared "Home"
*/ 
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
        // This is the default action when the user browses to the domain
        public IActionResult Index()
        {
            return View(Passenger.GetAll());
        }

        // creates a new Passenger based on user input
        public IActionResult Create(string FirstName, string LastName, string PhoneNumber)
        {
            Passenger.Create(FirstName, LastName, PhoneNumber);
            return RedirectToAction("Index");
        }

        // this was part of the default project.  To remove or not to remove?
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}