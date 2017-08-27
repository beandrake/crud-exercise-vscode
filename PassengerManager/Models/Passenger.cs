using System.Collections.Generic;


namespace PassengerManager.Models
{
  public class Passenger
  {
    private int ID;    
    private string FirstName;
    private string LastName;
    private string PhoneNumber;
    
    // creates a new Passenger and adds it to the list
    public static void Create(string FirstName, string LastName, string PhoneNumber)
    {
      var passenger = new Passenger();
      passenger.FirstName = FirstName;
      passenger.LastName = LastName;

      // NOTE!!!!!!!! add format verification?
      // remember to store only digits
      passenger.PhoneNumber = PhoneNumber;

      Home.PassengerList.Add(passenger);
    }
      
    public static List<Passenger> GetAll()
    {
      return Home.PassengerList;
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




    // source: https://stackoverflow.com/questions/188510/how-to-format-a-string-as-a-telephone-number-in-c-sharp#188616
    // public string getPhoneNumberAsString()
    // {
    //   return System.String.Format("{0:(###) ###-####}", PhoneNumber);
    // }

    // public int getPhoneNumberAsInt()
    // {
    //   return PhoneNumber;
    // }

  }
}