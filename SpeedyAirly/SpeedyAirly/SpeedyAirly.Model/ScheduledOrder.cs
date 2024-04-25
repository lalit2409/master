using SpeedyAirly.SpeedyAirly.Model;

public record ScheduledOrder(Flight flight, List<Order> order);
