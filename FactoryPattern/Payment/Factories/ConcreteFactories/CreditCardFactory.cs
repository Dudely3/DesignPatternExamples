using FactoryPattern.Payment.ConcretePayments;

namespace FactoryPattern.Payment.Factories
{
	public class CreditCardFactory : IPaymentFactory
	{
		public IPayment CreatePayment()
		{
			// Perform credit card-specific initialization or configuration
			// ...

			// Return a concrete credit card payment object
			return new CreditCardPayment();
		}
	}
}