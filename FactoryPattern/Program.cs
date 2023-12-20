// See https://aka.ms/new-console-template for more information
using FactoryPattern.Payment;
using FactoryPattern.Payment.Factories;


//Coding it like this requires you to know the type beforehand
IPaymentFactory creditCardFactory = new CreditCardFactory();
IPayment creditCardPayment = creditCardFactory.CreatePayment();
creditCardPayment.Pay(75.00);


//Using the payment factory, you don't need to know the type, and you can encapsulate logic over in that class.
IPayment payment = PaymentFactory.Create(PaymentMethod.CreditCard);
payment.Pay(75.00);