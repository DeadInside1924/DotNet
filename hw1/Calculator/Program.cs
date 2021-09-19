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
                string expression = Console.ReadLine();
                Calculator calculator = new Calculator(expression);
                Console.WriteLine(calculator.Calculate());
        }
    }
}
