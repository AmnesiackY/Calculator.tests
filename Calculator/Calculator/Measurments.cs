using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Measurments
    {

        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static double Div(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Enter a number not equal to 0");
            }
            else
            {
                return a / b;
            }
        }
        public static int Mult(int a, int b)
        {
            return a * b;
        }
        public static double Square(int a)
        {
            if (a < 0)
            {
                throw new ArgumentOutOfRangeException("Take the square root of a number is impossible");
            }
            else
            {
                return Math.Sqrt(a);
            }
        }
    }
}
