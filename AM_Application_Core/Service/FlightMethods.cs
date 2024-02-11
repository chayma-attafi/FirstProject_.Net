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
                   List<DateTime> dateTimes = new List<DateTime>();

                   foreach(Flight f in Flights)
                   {
                       if (f.Destination == destination)
                       {
                          dateTimes.Add(f.FlightDate);
                           Console.WriteLine(f.FlightDate);
                      }
                   }

                   return dateTimes;
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





    }
    }

