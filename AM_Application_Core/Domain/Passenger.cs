using System;
namespace AM_Application_Core.Domain
{
	public class Passenger
	{
		public String PassportNumber { get; set; }
		public String FirstName { get; set; }
		public String LastName { get; set; }
		public DateTime BirthDay { get; set; }
		public int TellNumber { get; set; }
		public String EmailAdress { get; set; }
		public int id { get; set; }


		public IList<Flight> Flights { get; set; }

        //tester polymorphisme

        //	public Boolean CheckProfile(string nom, string prenom) {
        //		if (FirstName.Equals(nom) && LastName.Equals(prenom))
        //			return true;
        //		else
        //			return false;
        //	}


        //	public Boolean CheckProfile(string nom, string prenom, string email)
        //   {
        //		return (FirstName.Equals(nom) && LastName.Equals(prenom) && EmailAdress.Equals(email));

        //    }

       	public Boolean CheckProfile(string nom, string prenom, string email=null)
          {
            if(email == null)
        		return (FirstName.Equals(nom) && LastName.Equals(prenom));
            else
                return (FirstName.Equals(nom) && LastName.Equals(prenom) && EmailAdress.Equals(email));
        }

        public virtual void PassengerType() { Console.WriteLine("I'm a passenger"); }


    }
}

