using System;

namespace MathOperations
{
    public class MathOperations
    {
        public int Factorial(int number)
        {
            int maxIteration = number;
            int result = 1;

            for (int i = 1; i <= maxIteration; i++)
            {
                result *= i;
            }

            return result;
        }

        public double CalculateTriangleArea(float a, float b, float c)
        {
            if (a <= 0 || b <= 0 || c <= 0) return -1;

            
            float p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}