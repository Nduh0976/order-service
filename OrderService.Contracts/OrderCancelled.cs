namespace OrderService.Contracts;

public class OrderCancelled
{
    public Guid OrderId { get; init; }

    public string Reason { get; init; } = default!;

    public DateTime CancelledAt { get; init; }
}
