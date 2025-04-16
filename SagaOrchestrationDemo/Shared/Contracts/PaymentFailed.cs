namespace Contracts;

public record PaymentFailed
{
    public Guid OrderId { get; init; }
    public string Reason { get; init; }
}