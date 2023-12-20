using FactoryPattern.Payment.ConcretePayments;

namespace FactoryPattern.Payment.Factories
{
	public class GooglePayFactory : IPaymentFactory
	{
		public IPayment CreatePayment()
		{
			// Perform Google Pay-specific initialization or configuration
			// ...

			// Return a concrete Google Pay payment object
			return new GooglePayPayment();
		}
	}
}