using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential12._4
{
    public enum CalcActions
    {
        plus = 0,
        minus = 1,
        multiply = 2,
        divide = 3,
        none=10
    }
    class Model
    {


        public double A { get; set; }
        public double B { get; set; }
        public int currentAction { get; set; }
        public double? Plus(double a, double b)
        {
            return a + b;
        }
        public double? Minus(double a, double b)
        {
            return a - b;
        }
        public double? Divide(double a, double b)
        {
            
            if (b==0)
            {
                return null;
            }
            else
            {
                return a / b;
            }
        }
        public double Multiply(double a,double b)
        {
            return a * b;
        }
    }
}
