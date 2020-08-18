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
            if(numTwo == 0)
            {
                throw new DivideByZeroException("You can not divide by zero");
            }
            return numOne / numTwo;
        }

        public string Equall(double first, double second, string opera)
        {
            string ret = "";
            if (opera == "+")
            {
                 ret = Addition(first, second).ToString();
            }
            else if (opera== "-")
            {
                  ret = Subtraction(first, second).ToString();
            }
            else if (opera == "X")
            {
                  ret = Multiplication(first, second).ToString();
            }
            else if (opera == "/")
            {
                  ret = Division(first, second).ToString();
            }
            return ret;
        }
    }
}
