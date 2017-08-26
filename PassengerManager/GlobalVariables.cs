using System.Collections.Generic;
using PassengerManager.Models;

namespace PassengerManager
{
  public static class GlobalVariables
  {
    public static List<Passenger> PassengerList { get; set; } = new List<Passenger>();
  }
}