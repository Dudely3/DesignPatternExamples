using System;

// PaymentFactory.cs (Abstract Factory Interface)
namespace FactoryPattern.Payment.Factories
{
	public interface IPaymentFactory
	{
		IPayment CreatePayment();
	}
}