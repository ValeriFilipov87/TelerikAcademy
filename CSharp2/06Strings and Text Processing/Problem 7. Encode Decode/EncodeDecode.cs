using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Encode_Decode
{
    class EncodeDecode
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string codeWord = Console.ReadLine();

            string encryptedResult = Encrypt(input, codeWord);
            Console.WriteLine(encryptedResult);
            string decryptResult = Decrypt(encryptedResult, codeWord);
            Console.WriteLine(decryptResult);

        }

        public static string Encrypt(string strIn, string strKey)
        {
            string sbOut = string.Empty;
            for (int i = 0; i < strIn.Length; i++)
            {
                sbOut += string.Format("{0:00}", strIn[i] ^ strKey[i % strKey.Length]);
            }
            return sbOut;
        }

        public static string Decrypt(string strIn, string strKey)
        {
            string sbOut = string.Empty;
            for (int i = 0; i < strIn.Length; i += 2)
            {
                byte code = Convert.ToByte(strIn.Substring(i, 2));
                sbOut += (char)(code ^ strKey[(i / 2) % strKey.Length]);
            }
            return sbOut;
        }

    }
}
