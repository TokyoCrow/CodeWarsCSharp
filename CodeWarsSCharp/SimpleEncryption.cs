using System;
using System.Text;

namespace Katas
{
    public static class SimpleEncryption
    {
        //https://www.codewars.com/kata/57814d79a56c88e3e0000786
        public static class AlternatingSplit
        {
            public static string Encrypt(string text, int n)
            {
                if (String.IsNullOrEmpty(text))
                    return text;
                else
                {
                    for (var i = 0; i < n; i++)
                        Encrypting(ref text);
                    return text;
                }
            }

            static void Encrypting(ref string text)
            {
                var firstPart = new StringBuilder();
                var secondPart = new StringBuilder();
                for (var i = 1; i <= text.Length; i++)
                {
                    if (i % 2 == 0)
                        firstPart.Append(text[i - 1]);
                    else
                        secondPart.Append(text[i - 1]);
                }
                text = $"{firstPart}{secondPart}";
            }

            public static string Decrypt(string encryptedText, int n)
            {
                if (String.IsNullOrEmpty(encryptedText))
                    return encryptedText;
                else
                {
                    for (var i = 0; i < n; i++)
                        Decrypting(ref encryptedText);
                    return encryptedText;
                }
            }

            static void Decrypting(ref string encryptedText)
            {
                var decryptedText = new StringBuilder();
                for (int i = 0, j = encryptedText.Length / 2; j < encryptedText.Length; i++,j++)
                {
                    decryptedText.Append(encryptedText[j]);
                    if (i < encryptedText.Length / 2)
                        decryptedText.Append(encryptedText[i]);
                }
                encryptedText = decryptedText.ToString();
            }
        }
    }
}
