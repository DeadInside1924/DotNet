using System;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
                string expression = string.Join(" ", args);
                //string expression = Console.ReadLine();
                Calculator calculator = new Calculator(expression);
                Console.WriteLine(calculator.Calculate());
        }
    }
}
