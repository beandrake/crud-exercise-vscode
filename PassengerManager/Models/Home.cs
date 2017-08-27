/*  
    the Models/Home.cs file is linked by default to:
      Views/Home/Index.cshtml and Controllers/HomeController.cs
    because of the shared "Home"
*/
using System.Collections.Generic;
using PassengerManager.Models;


// honestly, I'm not sure if this is the best location for this; still adapting to ASP.NET's structure for MVC
namespace PassengerManager
{
  public static class Home
  {
    public static List<Passenger> PassengerList { get; set; } = new List<Passenger>();
  }
}