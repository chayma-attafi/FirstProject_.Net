using System;
namespace AM_Application_Core.Domain
{
	public class Staff:Passenger
	{
		public DateTime EmployementDate { get; set; }
		public Double Salary { get; set; }
		public String Function { get; set; }

        public override void PassengerType()
        {
          //  base.PassengerType();
            Console.WriteLine("I am a staff member ");
        }
    }
}

