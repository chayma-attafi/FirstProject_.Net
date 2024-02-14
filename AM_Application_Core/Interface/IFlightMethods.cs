using System;
using AM_Application_Core.Domain;

namespace AM_Application_Core.Interface
{
	public interface IFlightMethods
	{
		public List<DateTime> GetFlightDates(string destination);
		public void GetFlights(string filterType, string filterValue);

		void ShowFlightDetails(Plane planne);
		int ProgrammeFlightNumber(DateTime startDate);
		double DurationAverage(string destination);
		IEnumerable<Flight> OrderDurationFlights();
		IEnumerable<Traveller> SeniorTravellers(Flight flight);
		IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights();
		

    }
}

