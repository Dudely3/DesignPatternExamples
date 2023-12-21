using FactoryPattern.Payment.ConcretePayments;

namespace FactoryPattern.Payment.Factories
{
	public class PaymentFactory
	{
		public static IPayment Create(PaymentMethodEnum paymentMethod)
		{
			//You have to add to this switch statement every time you 
			return paymentMethod switch
			{
				PaymentMethodEnum.CreditCard => new CreditCardPayment(),
				PaymentMethodEnum.PayPal => new PayPalPayment(),
				PaymentMethodEnum.GooglePay => new GooglePayPayment(),
				_ => throw new NotSupportedException(
											$"{paymentMethod} is not currently supported as a payment method."
									),
			};
		}
	}
	
}
