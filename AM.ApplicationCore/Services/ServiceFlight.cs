using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();


        //public List<DateTime> GetFlightDates(String destination)
        //{
        //    List<DateTime> result = new List<DateTime>();
        //    for (int i = 0; i < Flights.Count; i++)
        //    {
        //        if (Flights[i].Destination.Equals(destination))
        //        {
        //            result.Add(Flights[i].FlightDate);
        //        }
        //    }
        //    return result;
        //}

        /// methode foreach
        public IEnumerable<DateTime> GetFlightdates(string destination)
        {
            var query = from flight in Flights
                        where flight.Destination == destination
                        select flight.FlightDate;
            return query;
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            var query = from flight in Flights
                        where flight.FlightDate > startDate && flight.FlightDate < startDate.AddDays(7)
                        select flight;
            return query.Count();
        }

        public void ShowFlightDetails(Plane plane)
        {
            var query = from flight in Flights
                        where flight.Plane == plane
                        select flight;
            foreach (var item in query)
            {
                Console.WriteLine(item.FlightDate);
                Console.WriteLine(item.Destination);
            }
        }

        public float DurationAverage(string destination)
        {
            float result = 0;
            int i = 0;
            foreach (var flight in Flights)
            {
                if (flight.Destination.Equals(destination))
                {
                    result = result + flight.EstimatedDuration;
                    i++;
                }
            }
            return result / i;
        }

        public List<Flight> OrderedDurationFlights()
        {
            List<Flight> flights = new List<Flight>();

            foreach (var flight in Flights)
            {
                //flights.Add(flight.EstimatedDuration);
            }
            return flights;
        }



        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "destination":
                    foreach (var item in Flights)
                    {
                        if (item.Destination == filterValue)
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }
                    break;
                case "FlightDate":
                    foreach (var item in Flights)
                    {
                        if (item.FlightDate == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }
                    break;
                case "departure":
                    foreach (var item in Flights)
                    {
                        if (item.Departure == filterValue)
                        {
                            Console.WriteLine(item.FlightDate);
                        }
                    }
                    break;
                case "Flightid":
                    foreach (var item in Flights)
                    {
                        if (item.FlightID == int.Parse(filterValue))
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }
                    break;
            }
        }
    }
}
