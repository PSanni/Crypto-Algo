using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crypto
{
    class FeistalCipher
    {
        Int32 L, R = 0;
        String PlainText="";
        String Key = "";
        int round = 3;

        String Binary = "";
        String Binary_Key = "";



        public FeistalCipher(String PlainText, String Key, int round) {

            this.PlainText = PlainText;
            this.Key = Key;
            this.round = round;
            Binary = Utilities.StringToBinary(this.PlainText);
            Binary_Key = Utilities.StringToBinary(this.Key);
        }





    }


    
    

    class Utilities {

        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        public static string BinaryToString(string data)
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }

            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        public static Int32 OR(String str1, String str2) {

      
            Int32 Value1 = Convert.ToInt32(str1);
            Int32 Value2 = Convert.ToInt32(str2);
            return Value1 | Value2 ;
        }

        public static Int32 AND(String str1, String str2)
        {


            Int32 Value1 = Convert.ToInt32(str1);
            Int32 Value2 = Convert.ToInt32(str2);
            return Value1 & Value2;
        }

        public static Int32 XOR(String str1, String str2)
        {


            Int32 Value1 = Convert.ToInt32(str1);
            Int32 Value2 = Convert.ToInt32(str2);
            return Value1 ^ Value2;
        }
          
    }


}
