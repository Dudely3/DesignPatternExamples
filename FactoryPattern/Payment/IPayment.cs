
namespace FactoryPattern.Payment
{
	//This is the base class. All the other classes will have to implement the methods contained here
	public interface IPayment
	{
		void Pay(Double amount);
	}
}
