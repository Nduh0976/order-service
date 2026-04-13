namespace OrderService.Contracts;

// Published by a payment system (we'll simulate this)
public class PaymentReceived
{
    public Guid OrderId { get; init; }

    public decimal Amount { get; init; }

    public string Method { get; init; } = default!;

    public DateTime PaidAt { get; init; }
}
