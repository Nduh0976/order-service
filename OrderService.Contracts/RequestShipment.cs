namespace OrderService.Contracts;

public class RequestShipment
{
    public Guid OrderId { get; init; }

    public Guid CustomerId { get; init; }

    public string[] Items { get; init; } = [];
}
