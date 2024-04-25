
using SpeedyAirly.SpeedyAirly.Model;

namespace SpeedyAirly.SpeedyAirly.Contract
{
    public interface IScheduleOrder
    {
        void ScheduleOrders(Dictionary<string, Order> orders);
    }
}
