// See https://aka.ms/new-console-template for more information
using FactoryPattern.Payment;
using FactoryPattern.Payment.Factories;



//Coding it like this requires you to know the type beforehand, 
//but eliminates the need for a generic factory that has to change with every new type.
IPaymentFactory creditCardFactory = new CreditCardFactory(); //Dependency injection here could improve this- leave for a later lesson!
IPayment payment = creditCardFactory.CreatePayment();
payment.Pay(75.00);


//Using the payment factory, you don't need to know the type, 
//and you can still encapsulate payment logic over in type's class, 
//but this requires you to maintain a PaymentFactory class that changes every time a type gets added.
payment = PaymentFactory.Create(PaymentMethodEnum.CreditCard);
payment.Pay(75.00);


// Using a generic method, you can have the benefit of both of the above methods by using dependency injection. 
// Note this method doesn't require a payment factory class that you have to change each time, everything is decoupled. 
PaymentProcessor processor = new();
processor.ProcessPayment<PayPalFactory>(50.0);
processor.ProcessPayment<CreditCardFactory>(75.0);
processor.ProcessPayment<GooglePayFactory>(100.0);

