using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _RSA
{
    internal static class DataClass
    {
        public static BigInteger p;
        public static BigInteger q;
        public static BigInteger e;
        public static BigInteger d;
        public static BigInteger n;
        public static int currentKeyLen;
        public static List<BigInteger> primes = new List<BigInteger>();
        public static List<BigInteger> ePrimes = new List<BigInteger>();
        public static BigInteger Pow(this BigInteger value, BigInteger exponent)
        {
            BigInteger result = BigInteger.One;
            while (exponent > Int32.MaxValue)
            {
                result *= BigInteger.Pow(value, Int32.MaxValue);
                exponent -= Int32.MaxValue;
            }
            result *= BigInteger.Pow(value, (int)exponent);
            return result;
        }
    }
}
