using System;
using AM_Application_Core.Domain;

namespace AM_Application_Core.Interface
{
	public interface IFlightMethods
	{
		public List<DateTime> GetFlightDates(string destination);
    }
}

