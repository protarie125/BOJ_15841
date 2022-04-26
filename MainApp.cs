using System;
using System.Numerics;

namespace BOJ_15841
{
    internal static class MainApp
    {
        private static BigInteger[] memo_ = null;

        private static void Main(string[] args)
        {
            memo_ = new BigInteger[491];
            memo_[0] = 0;
            memo_[1] = 1;

            var n = default(int);
            while (true)
            {
                var line = Console.ReadLine();

                if ("-1" == line)
                {
                    break;
                }

                n = int.Parse(line);

                Console.WriteLine($"Hour {n}: {Fibo(n)} cow(s) affected");
            }
        }

        private static BigInteger Fibo(int n)
        {
            if (0 == memo_[n])
            {
                for (int i = 2; i <= n; i++)
                {
                    memo_[i] = Fibo(i - 1) + Fibo(i - 2);
                }
            }

            return memo_[n];
        }
    }
}