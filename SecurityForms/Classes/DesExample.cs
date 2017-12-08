using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityForms.Classes
{
    class DesExample
    {
        public byte[] T1 = { 1, 4, 6, 8, 3, 5, 2, 7 };
        public byte[] T2 = { 1, 7, 5, 2, 6, 3, 8, 4 };
        public byte[] T3 = { 4, 1, 2, 3, 2, 3, 4, 1 };
        public byte[] S1 = { 0, 2, 1, 3, 1, 0, 3, 2, 1, 3, 2, 0, 3, 0, 2, 1 };
        public byte[] S2 = { 1, 3, 0, 2, 0, 2, 3, 1, 0, 3, 0, 2, 2, 1, 0, 3 };
        public byte[] T4 = { 2, 1, 4, 3 };
        public byte[] T5 = { 2, 1 };

        public int[] C = new int[4];
        public int[] D = new int[4];

        public int[] getBlock(string input)
        {
            int[] inputBits = new int[8];
            for (int i = 0; i < 8; i++)
            {
                // For every character in the 8 bit input, we get its binary value
                // by first parsing it into an int and then converting to a binary
                // string
                
                string binary = Convert.ToString(int.Parse(input), 2);
                while (binary.Length < 8)
                {
                    binary = "0" + binary;
                }
                // Add the 4 bits we have extracted into the array of bits.
                for (int j = 0; j < 8; j++)
                {
                    inputBits[(8 * i) + j] = Convert.ToInt32(binary[j] + "");
                }
            }
            return inputBits;
        }
        public int[] getKey(string input)
        {
            int[] keyBits = new int[8];
            for (int i = 0; i < 8; i++)
            {
                string binary = Convert.ToString(int.Parse(input), 2);
                while (binary.Length < 4)
                {
                    binary = "0" + binary;
                }
                for (int j = 0; j < 4; j++)
                {

                    keyBits[(4 * i) + j] = Convert.ToInt32(binary[j] + "");
                }
            }
            return keyBits;
        }

        
        public void displayBits(int[] bits)
        {
            // Method to display int array bits as a hexadecimal string.
            for (int i = 0; i < bits.Length; i += 4)
            {
                StringBuilder output = new StringBuilder("");
                for (int j = 0; j < 4; j++)
                {
                    output.Append(bits[i + j]);
                }

            }

        }
        public int[] xor(int[] a, int[] b)
        {
            // Simple xor function on two int arrays
            int[] answer = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                answer[i] = a[i] ^ b[i];
            }
            return answer;
        }

        public int[] leftShift(int[] bits, int n)
        {
            int[] answer = new int[bits.Length];
            Array.ConstrainedCopy(bits, 0, answer, 0, bits.Length);
            for (int i = 0; i < n; i++)
            {
                int temp = answer[0];
                for (int j = 0; j < bits.Length - 1; j++)
                {
                    answer[j] = answer[j + 1];
                }
                answer[bits.Length - 1] = temp;
            }
            return answer;
        }
        //public string Encryption(string plain, string key)
        //{
        //    string binary;
            
        //     binary += Convert.ToString(int.Parse(plain), 2);

        //}

    }
}
