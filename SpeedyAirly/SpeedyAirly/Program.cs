using System.Text.Json;
using System.Reflection;
using System.Text;
using SpeedyAirly.SpeedyAirly.Model;
using SpeedyAirly.SpeedyAirly.Contract;
using SpeedyAirly.SpeedyAirly.Implementation;
using System;
namespace SpeedyAirly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var orders = JsonSerializer.Deserialize<Dictionary<string, Order>>(File.ReadAllText("coding-assigment-orders.json"));
                IFlightInfo flightInfo = new FlightInfo();
                IScheduleOrder scheduledOrder = new ScheduleOrder(flightInfo); ;

                flightInfo.DisplayFlightSchedule();

                scheduledOrder.ScheduleOrders(orders!);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error in processing:{exception.Message}");
            }

        }
    }
}
