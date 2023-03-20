using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Data
{
    class ReservationManager
    {
        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reservations.bin");

        public void save(List<Reservation> reservations)
        {
            using (BinaryWriter binWriter = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                reservations.ForEach(reservation =>
                {
                    binWriter.Write(UTF8Encoding.Default.GetBytes(
                       $"{reservation.ReservationCode}," +
                       $"{reservation.TravellerName}," +
                       $"{reservation.TravellerCitizenship}," +
                       $"{reservation.Flight.FlightCode}," +
                       $"{reservation.Flight.AirlineName}," +
                       $"{reservation.Flight.FromCodePort}," +
                       $"{reservation.Flight.ToCodePort}," +
                       $"{reservation.Flight.Day}," +
                       $"{reservation.Flight.DeptTime}," +
                       $"{reservation.Flight.PassengerSeats}," +
                       $"{reservation.Flight.Cost}," +
                       $"{reservation.Status}\n"
                   ));
                });
            }
        }
        public void save(Reservation reservation)
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose();
            }

            using (BinaryWriter binWriter = new BinaryWriter(File.Open(filePath, FileMode.Append)))
            {
                binWriter.Write(UTF8Encoding.Default.GetBytes(
                    $"{reservation.ReservationCode}," +
                    $"{reservation.TravellerName}," +
                    $"{reservation.TravellerCitizenship}," +
                    $"{reservation.Flight.FlightCode}," +
                    $"{reservation.Flight.AirlineName}," +
                    $"{reservation.Flight.FromCodePort}," +
                    $"{reservation.Flight.ToCodePort}," +
                    $"{reservation.Flight.Day}," +
                    $"{reservation.Flight.DeptTime}," +
                    $"{reservation.Flight.PassengerSeats}," +
                    $"{reservation.Flight.Cost}," +
                    $"{reservation.Status}\n"
                ));
            }
        }

        public List<Reservation> readFromStorage()
        {
            if (!File.Exists(filePath))
            {
                return new List<Reservation>();
            }

            List<Reservation> list = new List<Reservation>();
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string reservationCode = parts[0];
                    string travellerName = parts[1];
                    string travellerCitizenship = parts[2];
                    string flighCode = parts[3];
                    string airlineName = parts[4];
                    string fromPort = parts[5];
                    string toPort = parts[6];
                    string day = parts[7];
                    string deptTime = parts[8];
                    int passengerSeats = int.Parse(parts[9]);
                    double cost = Convert.ToDouble(parts[10]);
                    string status = parts[11];

                    Flight flight = new Flight(flighCode, airlineName, fromPort, toPort, day, deptTime, passengerSeats, cost);
                    Reservation reservation = new Reservation(travellerName, travellerCitizenship, flight, status);
                    reservation.ReservationCode = reservationCode;
                    list.Add(reservation);
                }
            }

            return list;
        }
    }
}
