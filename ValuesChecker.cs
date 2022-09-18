using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace TILab4
{
    public static class ValuesChecker
    {
        public static BigInteger TryParseValue(in string text)
        {
            BigInteger val;

            try
            {
                val = BigInteger.Parse(text);
            }catch(Exception ex)
            {
                return -1;
            }

            return val;
        }

        public static bool CheckQ(in string qStr)
        {
            return Algorithms.CheckPrimeDigitFerma(BigInteger.Parse(qStr));
        }

        public static bool CheckP(in string qStr, in string pStr)
        {
            BigInteger p = BigInteger.Parse(pStr);
            BigInteger q = BigInteger.Parse(qStr);

            if (!Algorithms.CheckPrimeDigitFerma(p))
            {
                return false;
            }

            
            return (p - 1) % q == 0;
        }

        public static bool CheckH(string qStr, string pStr, string hStr)
        {
            BigInteger h = BigInteger.Parse(hStr);
            BigInteger p = BigInteger.Parse(pStr);

            if (h < 2 || h > (p - 2))
            {
                return false;
            }

            BigInteger q = BigInteger.Parse(qStr);
            BigInteger g = Algorithms.FastPowMod(h, (p - 1) / q, p);

            if (g <= 1)
            { 
                return false;
            }

            return true;
        }

        public static bool CheckInterval(in BigInteger leftBound, in BigInteger rightBound,
            in BigInteger value)
        {
            if (value < leftBound || value > rightBound)
            {
                return false;
            }

            return true;
        }
    }
}
