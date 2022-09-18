using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace TILab4
{
    public static class Algorithms
    {
        public static bool CheckPrimeDigitFerma(in BigInteger x)
        {
            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                BigInteger a = rand.Next() % (x - 2) + 2;

                if (FastPowMod(a, x - 1, x) != 1)
                {
                    return false;
                }
            }

            return true;
        }

        public static BigInteger FastPowMod(BigInteger number, BigInteger power, in BigInteger mod)
        {
            BigInteger res = 1;

            while (power != 0)
            {
                while (power % 2 == 0)
                {
                    power /= 2;
                    number = (number * number) % mod;
                }

                power--;
                res = (res * number) % mod;
            }

            return res;
        }
    }
}
