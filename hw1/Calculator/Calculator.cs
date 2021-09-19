using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class Calculator
    {
        public Calculator()
        {
            
        }

        public double Calculate(string expression)
        {
            var mass = expression.Split();
            if (mass[1].Equals("/") && double.Parse(mass[2]) == 0)
                throw new Exception("Нельзя делить на ноль");
            
            
            if (mass.Length != 3)
            {
                throw new Exception("Не верная длина выражения");
            }

            var result = mass[1] switch
            {
                "+" => double.Parse(mass[0]) + double.Parse(mass[2]),
                "-" => double.Parse(mass[0]) - double.Parse(mass[2]),
                "*" => double.Parse(mass[0]) * double.Parse(mass[2]),
                "/" => double.Parse(mass[0]) / double.Parse(mass[2]),
                _ => throw new Exception("Не существует такой операции")
            };
            
            return result;
        }
    }
}
