using System.Xml.Serialization;

namespace SpeedyAirly.SpeedyAirly.Model
{
    public record Flight(int Number, string Departure, string Arrival, int Day, List<string> order = null);
}
