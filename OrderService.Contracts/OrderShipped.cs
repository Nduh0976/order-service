namespace OrderService.Contracts;

public class OrderShipped
{
    public Guid OrderId { get; init; }

    public string TrackingCode { get; init; } = default!;

    public DateTime ShippedAt { get; init; }
}
