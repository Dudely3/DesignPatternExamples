namespace FactoryPattern.Payment.Factories
{
	public class PaymentProcessor
	{
		public void ProcessPayment<TFactory>(double amount) where TFactory : IPaymentFactory, new()
		{
			IPaymentFactory paymentFactory = new TFactory();
			IPayment payment = paymentFactory.CreatePayment();
			payment.Pay(amount);
		}
	}

}
