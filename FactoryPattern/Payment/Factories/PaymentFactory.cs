using FactoryPattern.Payment.ConcretePayments;

namespace FactoryPattern.Payment.Factories
{
	public class PaymentFactory
	{
		public static IPayment Create(PaymentMethodEnum paymentMethod)
		{
			//You have to add to this switch statement every time you add a new payment method, which is a downside of setting up factories in this way,
			//but does not require any concrete factories so is sometimes simpler to implement. 
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
