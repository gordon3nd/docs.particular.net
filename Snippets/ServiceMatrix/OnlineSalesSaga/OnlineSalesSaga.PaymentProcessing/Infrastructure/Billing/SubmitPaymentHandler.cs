﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by ServiceMatrix.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using NServiceBus;
using OnlineSalesSaga.Internal.Commands.Billing;


namespace OnlineSalesSaga.Billing
{
    public partial class SubmitPaymentHandler : IHandleMessages<SubmitPayment>
    {
		
		public void Handle(SubmitPayment message)
		{
			// Handle message on partial class
			this.HandleImplementation(message);
		}

		partial void HandleImplementation(SubmitPayment message);

        public IBus Bus { get; set; }

    }

	
}