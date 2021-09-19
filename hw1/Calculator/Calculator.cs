using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class Calculator
    {
        private Parser parser;
        public Calculator(string expression)
        {
            parser = new Parser(expression);

        }
        
        public double Calculate()
        {
            return Convert.ToDouble(new DataTable().Compute($"{parser.Value1} {parser.Operation} {parser.Value2}", null));
        }
    }
}
