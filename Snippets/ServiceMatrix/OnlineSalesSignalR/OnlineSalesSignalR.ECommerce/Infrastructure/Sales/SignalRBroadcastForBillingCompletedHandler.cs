﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by ServiceMatrix.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NServiceBus;
using Microsoft.AspNet.SignalR;
using OnlineSalesSignalR.Contracts.Billing;

namespace OnlineSalesSignalR.Sales
{
	public class BroadcastBillingCompleted : IHandleMessages<BillingCompleted>
	{
		public void Handle(BillingCompleted message)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<BillingCompletedHub>();
            context.Clients.All.billingCompleted(message); 
        }
	}        

}