using System;
using AM_Application_Core.Domain;
using AM_Application_Core.Interface;

namespace AM_Application_Core.Service
{
	public class FlightMethods : IFlightMethods
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();



       



        //1 rer methode

        //   public List<DateTime> GetFlightDates(string destination)
        //   {
        //       List<DateTime> dateTimes = new List<DateTime>();
        //       for(int i=0; i<Flights.Count;i++)
        //       {
        //           if (Flights[i].Destination == destination)
        //           {
        //              dateTimes.Add(Flights[i].FlightDate);
        //               Console.WriteLine(Flights[i].FlightDate);
        //          }
        //       }

        //       return dateTimes;
        //  }


        //ForEach



        public List<DateTime> GetFlightDates(string destination)
               {
            /*     List<DateTime> dateTimes = new List<DateTime>();

                 foreach(Flight f in Flights)
                 {
                     if (f.Destination == destination)
                     {
                        dateTimes.Add(f.FlightDate);
                         Console.WriteLine(f.FlightDate);
                    }
                 }

                 return dateTimes;
            */

            //Linq
            /*
            var query = from f in Flights
                        where f.Destination == destination
                        select f.FlightDate;
            return query.ToList();
             */
             

            //avec lamda
            return Flights.Where(f => f.Destination == destination)
                .Select(a => a.FlightDate).ToList();

              }


        public void GetFlights(string filterType, string filterValue)
        {
            switch(filterType)
            {
                case "Destination":
                    {
                        foreach(Flight f in Flights)
                            if(f.Destination.Equals(filterValue))
                             Console.WriteLine(f);
                        break;
                          
                    }

                case "Departure":
                    {
                        foreach (Flight f in Flights)
                            if (f.Departure.Equals(filterValue))
                                Console.WriteLine(f);
                        break;

                    }

                case "EffectiveArrival":
                    {
                        foreach (Flight f in Flights)
                            if (f.EffectiveArrival.Equals(DateTime.Parse(filterValue)))
                                Console.WriteLine(f);
                        break;

                    }
                case "EstimatedDuration":
                    {
                        foreach (Flight f in Flights)
                            if (f.EstimatedDuration.Equals(int.Parse(filterValue)))
                                Console.WriteLine(f);
                        break;

                    }

                case "FlightDate":
                    {
                        foreach (Flight f in Flights)
                            if (f.FlightDate.Equals(DateTime.Parse(filterValue)))
                                Console.WriteLine(f);
                        break;

                    }
            }
        }









        public void ShowFlightDetails(Plane planne)
        {
            //LINQ
            /*var query = from f in Flights
                        where planne.Equals(f.plane)
                        select new { f.Destination, f.FlightDate };
            */

            //Lambda

            var query =Flights.Where(p => planne.Equals(p.plane)).Select(b => new { b.Destination, b.FlightDate });
            //p type : Flight
            //b : Flight respect la condition precedente
            foreach (var item in query)
            {
                Console.WriteLine("Flight date = " + item.FlightDate);
                Console.WriteLine("Destination = " + item.Destination);

            }
            

        }


        public int ProgrammeFlightNumber(DateTime startDate)
        {
            /* var query = from f in Flights
                         where DateTime.Compare(f.FlightDate, startDate)>0 && (startDate - f.FlightDate).TotalDays <= 7
                         select f;

             return query.Count();
            */
            //Lambda
            //1 ere methode
            //return Flights.Where(f => (startDate - f.FlightDate).TotalDays <= 7).Count();
            //2 eme methode
            return Flights.Count(f => (startDate - f.FlightDate).TotalDays <= 7);
            
        }

        public double DurationAverage(string destination)
        {
            /*var query = from f in Flights
                        where f.Destination.Equals(destination)
                        select f.EstimatedDuration;
            return query.Average();
            */

            return Flights.Where(f => f.Destination.Equals(destination))
                .Average(f => f.EstimatedDuration);

        }


        public IEnumerable<Flight> OrderDurationFlights()
        {
            /*var query = from f in Flights
                        orderby f.EstimatedDuration descending
                        select f;
            return query;
            */
            return Flights.OrderByDescending(f => f.Destination);

        }


        public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
            /* var req= from t in flight.Passengers.OfType<Traveller>()
                      orderby t.BirthDay descending
                      select t;
              return req.Take(3);
            */

            //Lambda
            return flight.Passengers.OfType<Traveller>()
            .OrderByDescending(p => p.BirthDay)
            .Take(3);

        }


        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights()
        {
            /* var req = from f in Flights
                       group f by f.Destination;
            */

            //Lambda

            var req = Flights.GroupBy(f => f.Destination);

            foreach (var i in req)
            {
                Console.WriteLine("Destination : "+i.Key);
                foreach (var f in i)
                Console.WriteLine("décollage: " + f.FlightDate);
            }

            return req;
        }

    }
}

