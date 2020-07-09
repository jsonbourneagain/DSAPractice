using System;
using System.Numerics;

namespace Karatsuba2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BigInteger x = BigInteger.Parse("3141592653589793238462643383279502884197169399375105820974944592");

            BigInteger y = BigInteger.Parse("2718281828459045235360287471352662497757247093699959574966967627");

            Console.WriteLine(multiply(x, y));
            Console.ReadKey();
        }

        public static BigInteger multiply(BigInteger x, BigInteger y)
        {
            BigInteger result = 0;

            int size1 = GetSize(x);
            int size2 = GetSize(y);

            //find the max size of two integers
            int N = Math.Max(size1, size2);

            if (N < 2)
                return x * y;

            //Max length divided by two and rounded up
            N = (N / 2) + (N % 2);

            //The mulitplying factor for calculating a,b,c,d
            BigInteger m = (BigInteger)Math.Pow(10, N);

            BigInteger b = x % m;
            BigInteger a = x / m;
            BigInteger c = y / m;
            BigInteger d = y % m;

            BigInteger z0 = multiply(a, c);
            BigInteger z1 = multiply(b, d);
            BigInteger z2 = multiply(a + b, c + d);

            result = ((BigInteger)Math.Pow(10, N * 2) * z0) + z1 + ((z2 - z1 - z0) * m);
            return result;
        }

        /// <summary>
        /// returns the size of the BigInteger integers
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int GetSize(BigInteger num)
        {
            int len = 0;
            while (num != 0)
            {
                len++;
                num /= 10;
            }
            return len;
        }
    }
}