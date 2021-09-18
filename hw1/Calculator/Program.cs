using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            string[] mass = expression.Split(' ');
            Parser.CheckOrError(mass);
            double val1 = Parser.ParseToDoubleOrError(mass[0]);
            double val2 = Parser.ParseToDoubleOrError(mass[2]);
            string oper = Parser.ParseOperatorOrError(mass[1]);
            double result = Calculator.Calculate(val1, val2, oper);
            Console.WriteLine($"{ val1} {oper} { val2}  = {result}");
        }
    }
}
