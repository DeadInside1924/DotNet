using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Calculator
{
    public class Parser
    {
        private string[] mass;
        public Parser(string expession)
        {
            mass = expession.Split(" ");
            CheckOrError();
        }

        public string  Operation
        {
            get
            {
                switch (mass[1])
                {
                    case "+":
                    {
                        return "+";
                    }
                        break;
                    case "-":
                    {
                        return "-";
                    }
                        break;
                    case "/":
                    {
                        return "/";
                    }
                        break;
                    case "*":
                    {
                        return "*";
                    }
                        break;
                    default:
                    {
                        throw new Exception("Не существует такого знака");
                    }

                }
            }
        }

        public double Value1
        {
            get
            {
                return ParseToDoubleOrError(mass[0]);
            }
        }
        
        public double Value2
        {
            get
            {
                return ParseToDoubleOrError(mass[2]);
            }
        }
        
        private double ParseToDoubleOrError(string val)
        {
            try
            {
                return Convert.ToDouble(val);
            }
            catch
            {
                throw new Exception("Не получилось конвертировать");
            }
        }

        [ExcludeFromCodeCoverage]
        private void CheckOrError()
        {
            if (mass.Length != 3)
                throw new Exception("Не верная длина массива");
        }
    }
}
