using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Calculator
{
    class Program
    {
        [ExcludeFromCodeCoverage]
        static void Main(string[] args)
        {
                var expression = Console.ReadLine();
                var calculator = new Calculator();
                var result = calculator.Calculate(expression);
                Console.WriteLine(result);
        }
    }
}
