using System;

namespace Crypto
{
    class CaesarCipher
    {
        Char[] Alphabets = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 
                           'o','p','q','r','s','t','u','v','w','x','y','z'}; //Character array of alphabets.
        
        private int key = 3;     //Contains the assigned key value 
        
        //Constructure to set key during initialization
        public CaesarCipher(int key) {
            if (key < 0 || key > 26 ) { throw new ArgumentOutOfRangeException("Key"); }
            this.key = key;
        }

        public CaesarCipher() { 
            // Empty Constructure.
            //Write your code here..... 
        }

        /// <summary>
        /// Set/Get Key value.
        /// </summary>
        public int Key {
           get
              {
                  return this.key;
              }
           set 
              {
                if (value < 0 || value > 26) { throw new ArgumentOutOfRangeException("Key"); }
                this.key = value;
              }
        
        }

        /// <summary>
        /// Encrypt the given plain text
        /// </summary>
        /// <param name="PlainText">Simple text to encrypt</param>
        /// <returns>Encrypted String</returns>
        public String Encrypt(String PlainText) {
            String temp="";
            PlainText = PlainText.ToLower();
            foreach (Char c in PlainText) {
                temp += getEnc(c);
            }
            return temp;
        }
    
        /// <summary>
        /// Decrypt the given cipher text
        /// </summary>
        /// <param name="CipherText">Cipher text to decrypt</param>
        /// <returns>Decrypted String</returns>
        public String Decrypt(String CipherText) {
            CipherText = CipherText.ToLower();
            String temp = "";
            foreach (Char c in CipherText) {
                temp += getDec(c);
            }
            return temp;
        }

   

        private Char getEnc(Char c) {
            
            int index = Array.IndexOf(Alphabets, c);
            index = (this.key + index) % 26;
            return Alphabets[index];
        }

        private Char getDec(Char c) { 

            int index = Array.IndexOf(Alphabets, c);
            index = (index - this.key) % 26;

            if (index < 0) {
                index = Convert.ToInt32(Math.Sqrt((index * index)));
                index = 26 - index;
            }
            return Alphabets[index];
        }
    }
}
