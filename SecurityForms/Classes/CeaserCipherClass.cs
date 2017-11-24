namespace SecurityForms.Classes
{
    class CeaserCipherClass
    {
        public  char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
               return ch;
            }
            char d = char.IsUpper(ch) ? 'A' : 'a'; //keep shape of letters
            return (char)((((ch + key) - d) % 26) + d);
        }
        public string Encipher(string input, int key)  //encryption method call cipher method
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);
            return output;
        }

        public string Decipher(string input, int key) //decryption method call encipher method
        {
            return Encipher(input, 26 - key);
        }
    }
}
