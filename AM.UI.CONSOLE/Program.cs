using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;

Console.WriteLine("Hello, World!");


Plane p = new Plane();
Plane p1 = new Plane();

ServiceFlight sf = new ServiceFlight();
sf.Flights = TestData.listFlights;

foreach (var item in sf.GetFlightDates("Paris"))
    Console.WriteLine(item);


sf.ShowFlightDetails(TestData.BoingPlane);

Console.WriteLine(sf.ProgrammedFlighNumber(new DateTime(2022, 05, 01, 17, 10, 10)));

Console.WriteLine(sf.DurationAverage("Paris"));

sf.GetFlights("destination", "Paris");