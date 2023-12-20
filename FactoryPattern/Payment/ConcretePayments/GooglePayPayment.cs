using System;

namespace FactoryPattern.Payment.ConcretePayments
{
	public class GooglePayPayment : IPayment
	{
		public void Pay(double amount)
		{
			// Google Pay-specific logic for processing a payment
			// ...

			Console.WriteLine($"Paid {amount:C} using a Google Pay.");
		}
	}
}
