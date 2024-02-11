using System;
namespace AM_Application_Core.Domain
{
	public class Flight
	{
		public int FlightId { get; set; }
		public DateTime FlightDate { get; set; }
		public int EstimatedDuration { get; set; }
		public DateTime EffectiveArrival { get; set; }
		public String Departure { get; set; }
		public String Destination { get; set; }

		public Plane plane { get; set; }

		public IList<Passenger> Passengers { get; set; }

        public override string ToString()
        {
			return "Destination = " + Destination + "\n"
				+ "Departure = " + Departure + "\n"
				+ "EffectiveArrival = " + EffectiveArrival + "\n"
				+ "EstimatedDuration = " + EstimatedDuration + "\n"
				+ "FlightDate = " + FlightDate + "\n";
        }


    }
}

