using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    internal class ServiceFlight
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
        public List<DateTime> GetFlightDates(String destination)
        {
            List<DateTime> result = new List<DateTime>();
            foreach (var flight in Flights)
            {
                if (flight.Destination.Equals(destination))
                {
                    result.Add(flight.FlightDate);
                }
            }
            return result;
        }



        public void ShowFlightDetails(Plane plane)
        {
            foreach (var flight in Flights)
            {
                if (flight.Plane == plane)
                {

                    Console.WriteLine(" Destination --> " + flight.Destination + " dans le date ---> " + flight.FlightDate);
                }
            }
        }

        public int ProgrammedFlighNumber(DateTime startDate)
        {
            int result = 0;
            foreach (var flight in Flights)
            {
                if (flight.FlightDate >= startDate && flight.FlightDate <= startDate.AddDays(7))
                {
                    result++;
                }
            }
            return result;
        }

        public float DurationAverage(string destination)
        {
            float result = 0;
            int i = 0;
            foreach (var flight in Flights)
            {
                if (flight.Destination.Equals(destination))
                {
                    result = (result + flight.);
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
    }
}
