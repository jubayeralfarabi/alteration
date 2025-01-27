﻿namespace Suit.AlterationService.Domain.Events
{
    using System;
    using Suit.AlterationService.Domain.ValueObjects;
    using Suit.Platform.Infrastructure.Core.Domain;

    /// <summary>Event for Alteration Creation.</summary>
    public class AlterationFinishedEvent : DomainEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlterationCreatedEvent"/> class.
        /// </summary>
        public AlterationFinishedEvent(Guid alterationId, AlterationStatusEnum status, string customerId)
        {
            this.AlterationId = alterationId;
            this.Status = status;
            this.CustomerId = customerId;
        }

        public Guid AlterationId { get; private set; }

        public string CustomerId { get; private set; }

        public AlterationStatusEnum Status { get; private set; }
    }
}
