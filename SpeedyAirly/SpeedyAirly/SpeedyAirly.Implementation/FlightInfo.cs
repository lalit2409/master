using SpeedyAirly.SpeedyAirly.Contract;
using SpeedyAirly.SpeedyAirly.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAirly.SpeedyAirly.Implementation
{
    public class FlightInfo : IFlightInfo
    {
        private List<Flight> _flights = new();

        public List<Flight> LoadFlightSchedule()
        {
            try
            {

                _flights.AddRange(new List<Flight>
        {
            new Flight(1,"YUL","YYZ",1),
            new Flight(2,"YUL","YYC",1),
            new Flight(3,"YUL","YVR",1),
            new Flight(4,"YUL","YYZ",2),
            new Flight(5,"YUL","YYC",2),
            new Flight(6,"YUL","YVR",2)
            });

                return _flights;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DisplayFlightSchedule()
        {
            try
            {
                _flights.ForEach(flight =>
                {
                    Console.WriteLine($"Flight: {flight.Number}, departure: {flight.Departure}, arrival: {flight.Arrival}, day: {flight.Day}");
                });
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
