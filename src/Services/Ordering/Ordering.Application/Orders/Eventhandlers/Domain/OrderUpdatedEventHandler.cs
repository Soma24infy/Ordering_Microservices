﻿namespace Ordering.Application.Orders.Eventhandlers.Domain
{
    public class OrderUpdatedEventHandler(ILogger<OrderUpdatedEventHandler> logger)
        : INotificationHandler<OrderUpdatedEvent>
    {
        public Task Handle(OrderUpdatedEvent notification, CancellationToken cancellationToken)
        {
            logger.LogInformation("Domain Event Handled: {DomainEvent}", notification.GetType().Name);
            return Task.CompletedTask;
        }
    }
}
