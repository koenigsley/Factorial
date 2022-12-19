using System;

namespace Factorial
{
    public static class FactorialFunction
    {
        public static double ComputeFactorial(int n)
        {
            EnsureNIsNotNegative(n);
            return ComputeFactorialRecursively(n);
        }

        private static void EnsureNIsNotNegative(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("n is negative");
            }
        }

        private static double ComputeFactorialRecursively(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * ComputeFactorialRecursively(n - 1);
        }
    }
}
