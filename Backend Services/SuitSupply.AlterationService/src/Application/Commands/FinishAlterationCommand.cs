﻿namespace SuitSupply.AlterationService.Application.Commands
{
    using SuitSupply.Platform.Infrastructure.Core.Commands;
    using System;

    public class FinishAlterationCommand : Command
    {
        public Guid AlterationId { get; set; }
    }
}