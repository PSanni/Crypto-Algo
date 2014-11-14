using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReilFence
{
    class CReilFence
    {
        String plainText;
        Char[] arr;
        String temp = "";

        public CReilFence(String str)
        {
            this.plainText = str;
        }
        public String Encrypt()
        {
            int Size = plainText.Count();
            for (int i = 0; i <= Size - 1; i = i + 2)
            {
                temp += plainText[i];
            }
            for (int i = 1; i <= Size - 1; i = i + 2)
            {
                temp += plainText[i];
            }
            return temp;
        }

        public String Decrypt()
        {
            String ctext = temp;
            int Size = ctext.Count();
            int start = Size / 2;
            int s = 0,p=start;
            temp = "";
            for (int i = 0; i <= start-1; i++)
            {
                temp += ctext[s++];
                temp += ctext[p++];
            }
            
            return temp;
        }

    }
}
