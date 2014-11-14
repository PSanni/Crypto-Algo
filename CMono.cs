using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoAlpha
{
    class CMono
    {
        Char[] alphabets = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', };
        Char[] Mono= new Char[26];
        int key = 3;
        String final;
        
        private void GenerateMonoTable()
        {
            int m = key;
            for (int i = 0; i <= 25; i++)
            {
                Mono[i] = alphabets[m++];
                if (m >= 25) { m = 0; }
            }

        }
        public CMono(int key) {
            this.key = key;
            GenerateMonoTable();
        }
        public String Encrypt(String pText) {
            foreach (Char c in pText)
            {
                int findex = getIndex(c, alphabets);
                final += getChar(findex, Mono);
            }
            return final;
        }

        public String Decrypt()
        {
            String cText = final;
            final = "";
            foreach (Char c in cText)
            {
                int findex = getIndex(c, Mono);
                final += getChar(findex, alphabets);
            }
            return final;
        }
        public int getIndex(Char c,Char [] arr)
        {
            for (int i = 0; i <= arr.Count() - 1; i++)
            {
                if (arr[i] == c) { return i; }
            }
            return 0;
        }
        public char getChar(int index,Char[] arr)
        {
            return arr[index];
        }
    }
}
