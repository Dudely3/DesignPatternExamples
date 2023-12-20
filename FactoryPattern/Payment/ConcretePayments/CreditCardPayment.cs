using System;

namespace FactoryPattern.Payment.ConcretePayments
{
	public class CreditCardPayment : IPayment
	{
		public void Pay(double amount)
		{
			// Credit card-specific logic for processing a payment
			// ...

			Console.WriteLine($"Paid {amount:C} using a credit card.");
		}
	}
}