/* Write a program that encodes and decodes a string using given encryption key 
 * (cipher). The key consists of a sequence of characters. The encoding/decoding 
 * is done by performing XOR (exclusive or) operation over the first letter of the 
 * string with the first of the key, the second – with the second, etc. When the 
 * last key character is reached, the next is the first.
 */
using System;
using System.Text;

class EncodeDecode
{
    static string Encrypt(string text, string cipher)
    {
        StringBuilder encryptedMsg = new StringBuilder(text.Length);
        char[] arr = new char[text.Length];
        for (int i = 0, j = 0; i < arr.Length;j++, i++)
        {
            if (!(j < cipher.Length))
            {
                j = 0;
            }
            arr[i] = cipher[j];
        }

        for (int i = 0; i < text.Length; i++)
        {
            encryptedMsg.Append((char)(text[i] ^ arr[i]));
        }
        return encryptedMsg.ToString();
    }

    static string Decrypt(string text, string cipher)
    {
        return Encrypt(text, cipher).ToString();
    }

    static void Main()
    {
        Console.WriteLine("Enter text to encode: ");
        string text = Console.ReadLine();

        string cipher = "key";

        string encrypted = Encrypt(text, cipher);
        Console.WriteLine(encrypted);

        string decrypted = Decrypt(encrypted, cipher);
        Console.WriteLine(decrypted);
    }
}