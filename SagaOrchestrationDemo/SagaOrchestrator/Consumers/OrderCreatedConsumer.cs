using Contracts;
using MassTransit;
using Microsoft.Extensions.Logging;

namespace SagaOrchestrator.Consumers;

public class OrderCreatedConsumer : IConsumer<OrderCreated>
{
    private readonly ILogger<OrderCreatedConsumer> _logger;

    public OrderCreatedConsumer(ILogger<OrderCreatedConsumer> logger)
    {
        _logger = logger;
    }

    public async Task Consume(ConsumeContext<OrderCreated> context)
    {
        var order = context.Message;

        _logger.LogInformation("Order Created: {OrderId}, Amount: {Amount}, Quantity: {Quantity}", order.OrderId, order.Amount, order.Quantity);

        // Start orchestration logic here, call downstream services (e.g., Inventory, Payment)
        // You can add retry logic and compensation here using Polly, or simply publish events to other services.

        // Example of what you'd do next in the saga:
        // await _publishEndpoint.Publish(new InventoryReserved { OrderId = order.OrderId, Amount = order.Amount });

        // This is just an example, you can create more consumers based on the different states of your saga.
    }
}