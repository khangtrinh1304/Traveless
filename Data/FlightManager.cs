using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Traveless.Data
{
    public class FlightManager
    {
        private const string FLIGHT_TEXT = @"C:\Traveless\Resources\Files\flights.csv";
        public List<Flight> flights = new List<Flight>();

        public enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public static string[] GetDayOptions()
        {
            return Enum.GetNames(typeof(Day));
        }


        public FlightManager()
        {
            populateFlight();
        }

        public void populateFlight()
        {
            Flight flight;
            foreach (string line in File.ReadLines(FLIGHT_TEXT))
            {
                string[] parts = line.Split(',');


                string flightCode = parts[0];
                string airlineName = parts[1];
                string fromCodePort = parts[2];
                string toCodePort = parts[3];
                string day = parts[4];
                string deptTime = parts[5];
                int passengerSeats = int.Parse(parts[6]);
                double cost = Convert.ToDouble(parts[7]);


                flight = new Flight(flightCode, airlineName, fromCodePort, toCodePort, day, deptTime, passengerSeats, cost);
                flights.Add(flight);
            }
        }

        public List<Flight> GetFlight()
        {
            return flights;
        }
    }
}
