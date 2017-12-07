using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityForms.Classes
{
    class RailFenceClass
    {
        public string Encrypt(string plaintext, string key)
        {
            string ciphertext = null;
            int j = 0, k = 0;

            string str = plaintext;
            //str= str.Trim();
            str = str.Replace(" ", "");
            char[] plaintextArray = str.ToCharArray();
            char[,] railarray = new char[2, 100];
            for (int i = 0; i < plaintextArray.Length; ++i)
            {
                if (i % 2 == 0)
                {
                    railarray[0, j] = plaintextArray[i];
                    ++j;
                }
                else
                {
                    railarray[1, k] = plaintextArray[i];
                    ++k;
                }
            }
            railarray[0, j] = '\0';
            railarray[1, k] = '\0';
            for (int x = 0; x < 2; ++x)
            {
                for (int y = 0; railarray[x, y] != '\0'; ++y) ciphertext += railarray[x, y];
            }
            return ciphertext;
        }
        public  string Decrypt(string ciphertext, string key)
        {
            string plaintext = null;
            int j = 0, k = 0, mid;
            char[] cipherArray = ciphertext.ToCharArray();
            char[,] railarray = new char[2, 100];
            if (cipherArray.Length % 2 == 0) mid = ((cipherArray.Length) / 2) - 1;
            else mid = (cipherArray.Length) / 2;
            for (int i = 0; i < cipherArray.Length; ++i)
            {
                if (i <= mid)
                {
                    railarray[0, j] = cipherArray[i];
                    ++j;
                }
                else
                {
                    railarray[1, k] = cipherArray[i];
                    ++k;
                }
            }
            railarray[0, j] = '\0';
            railarray[1, k] = '\0';
            for (int x = 0; x <= mid; ++x)
            {
                if (railarray[0, x] != '\0') plaintext += railarray[0, x];
                if (railarray[1, x] != '\0') plaintext += railarray[1, x];
            }
            return plaintext;
        }
    }
}
