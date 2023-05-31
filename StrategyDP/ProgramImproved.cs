namespace StrategyDP
{
    public interface IPaymentStrategy
    {
        void ProcessPayment(double amount);
    }

    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing credit card payment of ${amount}");
        }
    }

    public class PayPalPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount}");
        }
    }

    public class BitcoinPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Bitcoin payment of ${amount}");
        }
    }

    public class PaymentProcessor
    {
        private readonly IPaymentStrategy paymentStrategy;

        public PaymentProcessor(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(double amount)
        {
            paymentStrategy.ProcessPayment(amount);
        }
    }

}
