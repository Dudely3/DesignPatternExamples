
namespace FactoryPattern.Payment.Factories
{
	public interface IPaymentFactory
	{
		IPayment CreatePayment();
	}
}