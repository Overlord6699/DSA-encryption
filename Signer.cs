using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace TILab4
{
    public static class Signer
    {
        public static bool Sign(in byte[] initialMsg, in BigInteger q, in BigInteger p, in BigInteger k,
                                in BigInteger x, in BigInteger h, out BigInteger r, out BigInteger s)
        {
            var hash = Hash.GetHash(initialMsg,q);

            //g = h^((p−1)/q) mod p
            var g = Algorithms.FastPowMod(h, (p - 1) / q, p);

            //r = (g^k mod p) mod q
            r = Algorithms.FastPowMod(g, k, p) % q;
            //s = k^(−1) * (h(M) + x * r) mod q = k^(q-2) * (h(M) + x * r) mod q
            //по малой теореме Ферма
            s = Algorithms.FastPowMod(k, q - 2, q) * (hash + x * r) % q;

            return (r != 0 && s != 0);
        }

        public static bool CheckSign(in byte[] msg, in BigInteger r, in BigInteger s, in BigInteger q,
            in BigInteger p,in BigInteger h, in BigInteger x, 
            out BigInteger v, out BigInteger w,out BigInteger u1, out BigInteger u2)
        {
            //w = s^(−1) mod q = s^(q-2) mod q  по малой теореме Ферма
            w = Algorithms.FastPowMod(s, q - 2, q);

            var hash = Hash.GetHash(msg,q);

            //u1 = h(M)*w mod q
            u1 = hash * w % q;
            //u2 = r*w mod q
            u2 = r * w % q;

            //g = h^((p−1)/q) mod p
            var g = Algorithms.FastPowMod(h, (p - 1) / q, p);
            var y = Algorithms.FastPowMod(g, x, p);

            //v = (g^u1 * y^u2 mod p) mod q
            v = (Algorithms.FastPowMod(g, u1, p) * Algorithms.FastPowMod(y, u2, p) % p) % q;

            return v == r;
        }
    }
}
