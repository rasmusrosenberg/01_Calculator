using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _01_Calculator
{
    class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Sum(int[] input)
        {

            int sum = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }

            return sum;

        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Power(int a, int b)
        {

            double Result = Math.Pow(a, b);

            return Result;

        }

        public static int Factorial(int a)
        {

            // Returner 1 hvis tallet er 0 eller mindre
            if (a <= 0)
                return 1;
            else
            {

                int result = a;

                // Hvis a = 5, tæller den ned fra 4 til 1
                for (int i = (a-1); i >= 1; i--)
                {
                    result = result * i;
                }

                return result;

            }

        }

    }
}
