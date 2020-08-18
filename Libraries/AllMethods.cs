using System;

namespace Libraries
{
    public class AllMethods : ICalc
    {
        public double Addition(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        public double Subtraction(double numOne, double numTwo)
        {
            return numOne - numTwo;
        }

        public double Multiplication(double numOne, double numTwo)
        {
            return numOne * numTwo;
        }

        public double Division(double numOne, double numTwo)
        {
            return numOne / numTwo;
        }
    }
}
