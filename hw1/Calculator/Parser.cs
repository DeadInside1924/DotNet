using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Parser
    {
        public static double ParseToDoubleOrError(string expression)
        {
            try
            {
                return Convert.ToDouble(expression);
            }
            catch
            {
                throw new Exception("Не получилось конвертировать");
            }
        }
        public static string ParseOperatorOrError(string expression)
        {
            if (expression == "+")
                return "+";
            else if (expression == "-")
                return "-";
            else if (expression == "/")
                return "/";
            else if (expression == "*")
                return "*";
            else
                throw new Exception("Не существует такого знака");
        }

        public static string CheckOrError(string[] mass)
        {
            if (mass.Length==3)
            {
                return "1";
            }
            else 
                throw new Exception("Неверная строка");
        }
    }
}
