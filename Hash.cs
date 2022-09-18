using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace TILab4
{
    class Hash
    {
        public static BigInteger GetHash(byte[] input, in BigInteger q)
        {
            BigInteger h = 100;

            if(input != null)
                for (int i = 0; i < input.Length; i++)
                {
                    h = (h + input[i]) * (h + input[i]) % q;
                }

            return h;
        }
    }

}