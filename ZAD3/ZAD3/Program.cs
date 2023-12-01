using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZAD3
{
    internal class Program
    {
        public class Encrypter
        {
            public static string Encrypt(string input)
            {
                char[] encryptedChars = new char[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    // Шифрование: добавляем 1 к коду каждого символа
                    encryptedChars[i] = (char)(input[i] + 1);
                }
                return new string(encryptedChars);
            }

            public static string Decrypt(string encryptedInput)
            {
                char[] decryptedChars = new char[encryptedInput.Length];
                for (int i = 0; i < encryptedInput.Length; i++)
                {
                    // Расшифровка: вычитаем 1 из кода каждого символа
                    decryptedChars[i] = (char)(encryptedInput[i] - 1);
                }
                return new string(decryptedChars);
            }
        }

        class Program1
        {
            static void Main()
            {
                string originalText = "Azamat";

                // Шифрование
                string encryptedText = Encrypter.Encrypt(originalText);
                Console.WriteLine("Encrypted: " + encryptedText);

                // Расшифровка
                string decryptedText = Encrypter.Decrypt(encryptedText);
                Console.WriteLine("Decrypted: " + decryptedText);
            }
        }
    }
}
