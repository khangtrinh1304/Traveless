using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Data
{
    public class Flight
    {
        private string flightCode;
        private string airlineName;
        private string fromCodePort;
        private string toCodePort;
        private string day;
        private string deptTime;
        private int passengerSeats;
        private double cost;

        public Flight()
        {

        }

        public Flight(string flightCode, string airlineName, string fromCodePort, string toCodePort, string day, string deptTime, int passengerSeats, double cost)
        {
            FlightCode = flightCode;
            AirlineName = airlineName;
            FromCodePort = fromCodePort;
            ToCodePort = toCodePort;
            Day = day;
            DeptTime = deptTime;
            PassengerSeats = passengerSeats;
            Cost = cost;

        }
        public string FlightCode { get => flightCode; set => flightCode = value; }
        public string AirlineName { get => airlineName; set => airlineName = value; }
        public string FromCodePort { get => fromCodePort; set => fromCodePort = value; }
        public string ToCodePort { get => toCodePort; set => toCodePort = value; }
        public string Day { get => day; set => day = value; }
        public string DeptTime { get => deptTime; set => deptTime = value; }
        public int PassengerSeats { get => passengerSeats; set => passengerSeats = value; }
        public double Cost { get => cost; set => cost = value; }

        //public override string ToString()
        //{
            //return string.Format("{0} ({1}) from {2} to {3} on {4} depart at {5} seat ({6}) cost ({7})", FlightCode, AirlineName, FromCodePort, ToCodePort, Day, DeptTime,PassengerSeats, Cost);
       // }
    }
}
