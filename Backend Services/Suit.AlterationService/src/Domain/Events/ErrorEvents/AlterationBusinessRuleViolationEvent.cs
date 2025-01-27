﻿namespace Suit.AlterationService.Domain.Events
{
    using System;
    using FluentValidation.Results;
    using Newtonsoft.Json;
    using Suit.Platform.Infrastructure.Core.Events;
    using Suit.Platform.Infrastructure.Domain;

    /// <summary>Event for alteration business violation rule.</summary>
    public class AlterationBusinessRuleViolationEvent : FailedToProcessEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlterationBusinessRuleViolationEvent"/> class.
        /// </summary>
        public AlterationBusinessRuleViolationEvent(
            string entityId,
            string action,
            object dto = null,
            EventMessage[] eventMessages = null,
            string exception = null,
            ValidationResult validationResult = null)
            : base(exception)
        {
            this.EntityId = entityId;
            this.Action = action;
            this.Dto = dto;
            this.EventMessages = eventMessages;
        }

        /// <summary>
        /// Gets or sets Shop.
        /// </summary>
        public string EntityId { get; set; }

        public string Action { get; set; }

        public object Dto { get; set; }

        public EventMessage[] EventMessages { get; set; }

        public override string GetMessage()
        {
            return JsonConvert.SerializeObject(this.EventMessages);
        }
    }
}
