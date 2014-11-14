using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GCD
{
    class CGCD
    {
        public String GCD(int no1, int no2) {
            int max = 0;
            String temp="";
            if (no1 > no2) { max = no1; } else { max = no2; }
            for (int i = 1; i <= max; i++) {
                if (no1 % i == 0 && no2 % i == 0) {
                    temp += i.ToString()+" ";      
                }
            }
            return temp;
        }
    }
}
