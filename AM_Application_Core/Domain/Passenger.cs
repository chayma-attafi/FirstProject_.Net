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
	}
}

