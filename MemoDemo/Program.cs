using System;
using System.Collections.Generic;
using System.Numerics;

namespace MemoDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = (args.Length > 0) ? int.Parse(args[0]) : 10;
            Console.Write("Fibonacci({0}) = {1:N0}", n, Fibonacci(n));
        }

        private static BigInteger Fibonacci(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            if (n <= 1)
            {
                return 1;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}