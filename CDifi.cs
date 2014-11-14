using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Difi
{
    class CDifi
    {
        int p = 7, q = 3;
        int xa = 9, xb = 8;
        int ya = 0, yb = 0, ka = 0, kb = 0;
        public String Generate() { 
            //ya=q[xa] mod p;
            ya =Convert.ToInt32( Math.Pow(q, xa)) % p;
            //yb=q[xb] mod p;
            yb = Convert.ToInt32(Math.Pow(q, xb)) % p;
            //ka=yb[xa] mod p;
            ka = Convert.ToInt32(Math.Pow(yb, xa)) % p;
            //kb=ya[xb] mod p;
            kb = Convert.ToInt32(Math.Pow(ya, xb)) % p;
            return ka.ToString() + " " + kb.ToString();
        }
        
    }
}
