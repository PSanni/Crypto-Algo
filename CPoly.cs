using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolyAlphabetics
{
    class CPoly
    {
        Char[] alphabets = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n','o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', };
        
        String key = "";
        Char[] encrypted;
        Char[] decrypted;
        Char[,] table;
        public CPoly(String key)
        {
            this.table = VegenereTable();
            this.key = key;
        }

        public String Encrypt(String pText)
        {
            int keyCount = 0, ecounter = 0; ;
            encrypted = new Char[pText.Count()];
            for(int i=0;i<pText.Count();i++)
            {
                 int indexK=getIndex(key[keyCount++]);
                 if (keyCount >= key.Count()) { keyCount = 0; }
                 int indexP = getIndex(pText[i]);
                 encrypted[ecounter++] = table[indexK, indexP];
            }
            return new String(encrypted);
        }
        public String Decryption() {
            String cText = new String(encrypted);
            int indexK = 0, indexC = 0,keyCount=0;
            decrypted = new Char[cText.Count()];
            for (int i = 0; i < cText.Count();i++ )
            {
                indexK = getIndex(key[keyCount++]);
                if (keyCount >= key.Count()) { keyCount = 0; }
                indexC = getIndex(cText[i]);
                indexC = indexC - indexK;
                if (indexC < 0) { indexC = Convert.ToInt32(Math.Sqrt(indexC * indexC));
                indexC = 26 - indexC;
                }
                decrypted[i] = getChar(indexC);
            }
            return new String(decrypted);
        }
        private Char[,] VegenereTable()
        {
            Char[,] table = new Char[26, 26];
            int m = 0;

            for (int i = 0; i < 26; i++)
            {
                m = i;
                for (int j = 0; j < 26; j++)
                {
                    table[i, j] = alphabets[m++];
                    if (m >= 26) { m = 0; }
                }

            }
            return table;
        }

        public int getIndex(Char c)
        {
            for (int i = 0; i <= alphabets.Count() - 1; i++)
            {
                if (alphabets[i] == c) { return i; }
            }
            return 0;
        }
        public char getChar(int index)
        {
            return alphabets[index];
        }
    }
}
