using System;
namespace AM_Application_Core.Domain
{
	public class Traveller:Passenger
	{

		public String HealthInformation { get; set; }
		public String Nationality { get; set; }


        public override void PassengerType()
        {
            //base.PassengerType();
            Console.WriteLine("I am a Trvailleur member ");
        }
    }
}

