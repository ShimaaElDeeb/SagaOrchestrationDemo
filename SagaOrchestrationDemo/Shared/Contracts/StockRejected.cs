namespace Contracts;

public record StockRejected
{
    public Guid OrderId { get; init; }
    public string Reason { get; init; }
}