using SpeedyAirly.SpeedyAirly.Model;

namespace SpeedyAirly.SpeedyAirly.Contract
{
    public interface IFlightInfo
    {
        void DisplayFlightSchedule();
        List<Flight> LoadFlightSchedule();
    }
}
