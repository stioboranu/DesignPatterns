namespace ProxyDP
{
    public interface ICalculator
    {
        double Add(double a, double b);
        double Subtract(double a, double b);
        double AddAndSubtract(double a, double b, double c);
    }

    public class CalculatorProxy : ICalculator
    {
        private Calculator calculator;

        public CalculatorProxy()
        {
            // The actual Calculator object will be created on demand
        }

        private Calculator GetCalculator()
        {
            if (calculator == null)
            {
                calculator = new Calculator();
            }

            return calculator;
        }

        public double Add(double a, double b)
        {
            // Perform additional operations before delegating to the actual Calculator object
            Console.WriteLine("Performing some additional operations before adding.");

            Calculator calculator = GetCalculator();
            return calculator.Add(a, b);
        }

        public double Subtract(double a, double b)
        {
            // Perform additional operations before delegating to the actual Calculator object
            Console.WriteLine("Performing some additional operations before subtracting.");

            Calculator calculator = GetCalculator();
            return calculator.Subtract(a, b);
        }

        public double AddAndSubtract(double a, double b, double c)
        {
            Console.WriteLine("Performing ceva....");
            return Subtract(Add(a, b), c); 
        }
    }

}
