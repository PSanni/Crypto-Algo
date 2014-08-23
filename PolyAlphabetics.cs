using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polyalphabetics
{
    class PolyAlphabetics
    {

        Char[,] VTable = VigenereTable();
        Char[] Encrypted;

        String PlainText,Key;
        public String Encrypt(String text,String key) {
            if (Key.Count() > text.Count()) { throw new ArgumentException("Key size must less or equal to Plain text"); }
            this.PlainText = text;
            this.Key = key;
            DoEncryption();

            return new String(Encrypted);
        }
        private void DoEncryption(){
            int tindex=0,etindex=0;
            Encrypted= new Char[PlainText.Count()];
            for (int i = 0; i < PlainText.Count() ; i++) 
            {
                int x=GetIndexOfChar(Key[tindex++]);
                int y=GetIndexOfChar(PlainText[etindex]);
                Encrypted[etindex] = VTable[x,y ];
                etindex++;
                if (tindex >= Key.Count() ) { tindex = 0; }                           
            }  
        }
        public static Char[,] VigenereTable()
        { 
           Char[,] Table= new Char[26,26];
           int m=1, n = 0;
           for (int i = 0; i <26; i++) 
           {
               m = i;
               for (int j = 0; j < 26; j++)
               {
                   Table[i, j] = GetCharOfIndex(m++);
                   if (m >= 26) { m = 0; }

               }
              
           }
           return Table;
        }
        public static char GetCharOfIndex(int index) 
        {
            char[] alpha ={'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s'
                           ,'t','u','v','w','x','y','z'};
            return alpha[index];
        }
        public static int GetIndexOfChar(char value) {
            char[] alpha ={'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s'
                           ,'t','u','v','w','x','y','z'};
            for (int i = 0; i < 26; i++) {
                if (alpha[i] == value) { return i; }
            }
            return -1;
        }
    }
}
