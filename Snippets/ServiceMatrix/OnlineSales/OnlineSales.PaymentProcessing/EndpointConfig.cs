﻿using NServiceBus;
using NServiceBus.Persistence;
 
namespace OnlineSales.PaymentProcessing
{
    public partial class EndpointConfig    
    {
        public void Customize(BusConfiguration configuration)
        {
            configuration.UsePersistence<RavenDBPersistence>();
        }
    }
}