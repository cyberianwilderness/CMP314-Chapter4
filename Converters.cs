using System;

namespace UtilityKnife.Converters
{
    public class FahrenheitToCelsius
    {
        public double FahrenheitToCelsius(double FahrenheitTemp)
        {
            double _celsius = 0.0;
            // (F – 32) * 5/9
            var step1 = Calculator.Calculator.Subtract(fahrenheitTemp, 32);
            var step2 = Calculator.Calculator.Multiplication(step1, 5.0);
            _celsius = Calculator.Calculator.Division(step2, 9.0);
            return _celsius;
        }
        static void Main(string[] args)
		{
            Console.WriteLine("Hello World!");
            // skeleton program
        }
    }
}
public class Class1
{
	public Class1()
	{
	}
}
