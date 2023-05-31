using StrategyDP;

//PaymentProcessor paymentProcessor = new PaymentProcessor();
//paymentProcessor.ProcessPayment("Bitcoin", 100);
//paymentProcessor.ProcessPayment("PayPal", 100);
IPaymentStrategy bitcoinPaymentStrategy = new BitcoinPaymentStrategy();
IPaymentStrategy payPalPaymentStrategy = new PayPalPaymentStrategy();
var paymentProccesor = new PaymentProcessor(bitcoinPaymentStrategy);
paymentProccesor.ProcessPayment(100);
paymentProccesor = new PaymentProcessor(payPalPaymentStrategy);
paymentProccesor.ProcessPayment(100);

//public class PaymentProcessor
//{
//    public void ProcessPayment(string paymentMethod, double amount)
//    {
//        if (paymentMethod == "CreditCard")
//        {
//            // Process credit card payment
//            Console.WriteLine($"Processing credit card payment of ${amount}");
//        }
//        else if (paymentMethod == "PayPal")
//        {
//            // Process PayPal payment
//            Console.WriteLine($"Processing PayPal payment of ${amount}");
//        }
//        else if (paymentMethod == "Bitcoin")
//        {
//            // Process Bitcoin payment
//            Console.WriteLine($"Processing Bitcoin payment of ${amount}");
//        }
//        else
//        {
//            throw new ArgumentException("Invalid payment method.");
//        }
//    }
//}
