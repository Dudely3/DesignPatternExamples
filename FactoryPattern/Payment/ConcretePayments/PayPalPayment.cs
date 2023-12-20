using System;

namespace FactoryPattern.Payment.ConcretePayments
{
	public class PayPalPayment : IPayment
	{
		public void Pay(double amount)
		{
			// PayPal-specific logic for processing a payment
			// ...

			Console.WriteLine($"Paid {amount:C} using PayPal.");
		}
	}
}