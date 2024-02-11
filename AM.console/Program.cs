// See https://aka.ms/new-console-template for more information
using AM_Application_Core.Domain;
using AM_Application_Core.Service;

Console.WriteLine("Hello, World!");

//Plane plane = new Plane();
//plane.Capacite = 20;
//Plane p2 = new Plane(200, new DateTime(2302 / 02 / 09));



//initizateur d'objet
Plane p3 = new Plane
{

    Capacite = 20,
    PlaneTypee = PlaneType.Boing,
    ManuFactureDate = DateTime.Now,

};
Console.WriteLine(p3);

//CheckProfile

Passenger p1 = new Passenger
{
    FirstName = "aaa",
    LastName ="bbb" ,
    EmailAdress ="aaa@bbb.com",
};

Console.WriteLine(p1.CheckProfile("aaa", "bbb"));
Console.WriteLine(p1.CheckProfile("ahh", "bhhh"));
Console.WriteLine(p1.CheckProfile("aaa", "bbb", "aaa@bbb.com"));

//Tester PassengerType

Staff s1 = new Staff();
Traveller t1 = new Traveller();

p1.PassengerType();

s1.PassengerType();
t1.PassengerType();

Console.WriteLine("***** GetFlightsDate");
FlightMethods fm = new FlightMethods();
fm.Flights = TestData.listFlights;
fm.GetFlightDates("Madrid");

Console.WriteLine("***** GetFlights");
fm.GetFlights("EstimatedDuration", "105");
