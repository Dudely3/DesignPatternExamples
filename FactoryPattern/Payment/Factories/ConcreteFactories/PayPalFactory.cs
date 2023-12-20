using FactoryPattern.Payment.ConcretePayments;

namespace FactoryPattern.Payment.Factories
{
	public class PayPalFactory : IPaymentFactory
	{
		public IPayment CreatePayment()
		{
			// Perform PayPal-specific initialization or configuration
			// ...

			// Return a concrete PayPal payment object
			return new PayPalPayment();
		}

	}
}