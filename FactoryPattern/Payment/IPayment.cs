using System;

namespace FactoryPattern.Payment
{
	public interface IPayment
	{
		void Pay(Double amount);
	}
}
