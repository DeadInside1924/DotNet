using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        public static double Calculate(double val1, double val2, string oper)
        {
            switch (oper)
            {
                case "+":
                    {
                        return val1 + val2;
                    }
                    break;

                case "-":
                    {
                        return val1 - val2;
                    }
                    break;

                case "/":
                    {
                        return val1 / val2;
                    }
                    break;

                case "*":
                    {
                        return val1 * val2;
                    }
                    break;

                default:
                    {
                       throw new Exception("Неверная строка");
                    }
                    break;
            }
        }
    }
}
