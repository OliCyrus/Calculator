using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b) { return (a + b); }
        public double Sub(double a, double b) { return (a - b); }
        public double Div(double a, double b)
        {
            try
            {
                if (b.Equals(0))
                    throw new System.DivideByZeroException();
                else
                    return (a / b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Attempted divide by zero.");
                return 0;
            }
        }
        public double Mul(double a, double b)
        {
            return (a * b);
        }
    }
}
