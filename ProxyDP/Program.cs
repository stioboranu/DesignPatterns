using ProxyDP;

//Calculator calculator = new Calculator();
CalculatorProxy calculator = new CalculatorProxy();
Console.WriteLine(calculator.Add(5,5));
Console.WriteLine(calculator.Subtract(5,5));
Console.WriteLine(calculator.AddAndSubtract(7, 9, 3));


public class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }
}
