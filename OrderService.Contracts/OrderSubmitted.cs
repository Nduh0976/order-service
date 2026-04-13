namespace OrderService.Contracts;

public class OrderSubmitted
{
    public Guid OrderId { get; init; }

    public Guid CustomerId { get; init; }

    public string[] Items { get; init; } = [];

    public decimal Total { get; init; }

    public DateTime SubmittedAt { get; init; }
}
