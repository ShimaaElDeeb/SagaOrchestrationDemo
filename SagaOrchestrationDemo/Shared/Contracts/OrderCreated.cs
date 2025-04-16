namespace Contracts;

public record OrderCreated
{
    public Guid OrderId { get; init; }
    public decimal Amount { get; init; }
    public int Quantity { get; init; }
}