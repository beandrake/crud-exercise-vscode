using System.Collections.Generic;

namespace PassengerManager.Models
{
  public class Passenger
  {
    private int ID;    
    private string FirstName;
    private string LastName;
    private string PhoneNumber;
    
      
    public static void Create(string FirstName, string LastName, string PhoneNumber)
    {
      var passenger = new Passenger();
      passenger.FirstName = FirstName;
      passenger.LastName = LastName;
      passenger.PhoneNumber = PhoneNumber;

      GlobalVariables.PassengerList.Add(passenger);
    }
      
    public static List<Passenger> GetAll()
    {
      return GlobalVariables.PassengerList;
    }

    public string getFirstName()
    {
      return FirstName;
    }

    public string getLastName()
    {
      return LastName;
    }

    public string getPhoneNumber()
    {
      return PhoneNumber;
    }


  }
}