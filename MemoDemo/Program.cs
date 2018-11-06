using System;
using System.Collections.Generic;
using System.Numerics;

namespace MemoDemo
{
    internal class Program
    {
        private static List<BigInteger> memo = new List<BigInteger>(100);

        public static void Main(string[] args)
        {
            var n = (args.Length > 0) ? int.Parse(args[0]) : 10;
            memo.Add(0);
            memo.Add(1);
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

            if (memo.Count >= n && memo[n] >= 0)
            {
                return memo[n];
            }

            Expand(n);
            var fib = Fibonacci(n - 1) + Fibonacci(n - 2);
            memo[n] = fib;
            return fib;
        }

        private static void Expand(int n)
        {
            while (memo.Count <= n)
            {
                memo.Add(-1);
            }
        }
    }
}