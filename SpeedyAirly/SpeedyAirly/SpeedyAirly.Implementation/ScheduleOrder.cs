using SpeedyAirly.SpeedyAirly.Contract;
using SpeedyAirly.SpeedyAirly.Model;
using System.Runtime.Serialization;

namespace SpeedyAirly.SpeedyAirly.Implementation
{
    public class ScheduleOrder:IScheduleOrder
    {
        private List<ScheduledOrder> _scheduledOrders = new();
        private List<string> _processedOrder = new();
        private List<Flight> _flights = new();

        public ScheduleOrder(IFlightInfo flightInfo) {
            _flights = flightInfo.LoadFlightSchedule();
        }

        public void ScheduleOrders(Dictionary<string, Order>? orders)
        {
            try
            {
                int totalOrders = orders.Count();
                List<Order> flightorder;
                foreach (var flight in _flights)
                {
                    flightorder = new List<Order>();
                    foreach (var order in orders)
                    {
                        if (order.Value.destination == flight.Arrival && !_processedOrder.Contains(order.Key))
                        {
                            if (flightorder.Count == 20)
                                break;
                            flightorder.Add(new Order(order.Key, order.Value.destination));
                            _processedOrder.Add(order.Key);
                        }
                    }
                    _scheduledOrders.Add(new ScheduledOrder(flight, flightorder));
                }
                int count = 0;
                _scheduledOrders.ForEach(scheduleOrder => scheduleOrder.order.ForEach(order =>
                {
                    Console.WriteLine($"Order: {order.orderId}, FlightNumber: {scheduleOrder.flight.Number}, departure:{scheduleOrder.flight.Departure}, arrival: {scheduleOrder.flight.Arrival}, day: {scheduleOrder.flight.Day}");

                }));

                var _unscheduledOrders = orders.Where(p => !_scheduledOrders.Any(scheduleOrder => scheduleOrder.order.Any(p2 => p2.orderId == p.Key)));
                foreach (var item in _unscheduledOrders)
                {
                    Console.WriteLine($"Order: {item.Key}, FlightNumber:not scheduled");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
