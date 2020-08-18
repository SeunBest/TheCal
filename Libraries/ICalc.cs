using System;
using System.Collections.Generic;
using System.Text;

namespace Libraries
{
    public interface ICalc
    {
        public double Multiplication(double a, double b);
        public double Division(double a, double b);
        public double Subtraction(double a, double b);
        public double Addition(double a, double b);
        public string Equall(double a, double b, string c);
    }
}
