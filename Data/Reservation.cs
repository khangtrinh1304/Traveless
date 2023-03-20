using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Traveless.Data
{
    [Serializable]
    class Reservation
    {
        private string reservationCode;
        private string travellerName;
        private string travellerCitizenship;
        private Flight flight;
        private string status;

        public string ReservationCode { get => reservationCode; set => reservationCode = value; }
        public string TravellerName { get => travellerName; set => travellerName = value; }
        public string TravellerCitizenship { get => travellerCitizenship; set => travellerCitizenship = value; }
        public Flight Flight { get => flight; set => flight = value; }
        public string Status { get => status; set => status = value; }

        public Reservation(string travellerName, string travellerCitizenship, Flight flight, string status)
        {
            ReservationCode = generateReservationCode();
            TravellerName = travellerName;
            TravellerCitizenship = travellerCitizenship;
            Flight = flight;
            Status = status;
        }
        private string generateReservationCode()
        {
            Random random = new Random();
            return $"{(char)random.Next('A', 'Z' + 1)}{random.Next(0, 10)}{random.Next(0, 10)}{random.Next(0, 10)}{random.Next(0, 10)}";
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} ({2}), {3} - {4}", ReservationCode, Flight, travellerName, travellerCitizenship, status);
        }
    }
}
