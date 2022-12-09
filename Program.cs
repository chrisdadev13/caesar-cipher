using System;
using System.IO;

class CaesarCipher
{
        static void Main(string[] args)
        {
                CaesarCipher cipher = new CaesarCipher();
                string word, result;
                int keyValue;
                Console.WriteLine("Enter the word you want to translate");
                word = Console.ReadLine();
                Console.WriteLine("Enter the key value");
                keyValue = Convert.ToUInt16(Console.ReadLine());
                result = cipher.translate(word, keyValue);
                Console.WriteLine(result);
        }
        public string translate(string word, int key)
        {
                char letter, translated;
                string translation = "";

                for(int i = 0; i < word.Length; i++)
                {
                        if(word[i] >= 'a' && word[i] <= 'z')
                        {
                                letter = word[i];
                                translated = (char)(Convert.ToUInt16(letter) + key);
                                translation += translated;
                        }
                        else 
                        {
                                translation += word[i];
                        }
                }

                return translation;
        }

}