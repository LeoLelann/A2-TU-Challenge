using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            string result = "";

            for (int i = 0; i != input.Length + 1; i += 2)
            {
                if (i == input.Length)
                {
                    i = 1;
                }
                result += input[i];
            }
            return result;
        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null)
            {
                return (true);
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                    return (false);
            }
            return true;
        }

        public static string MixString(string a, string b)
        {
            string c = "";

            if (IsNullEmptyOrWhiteSpace(a) || IsNullEmptyOrWhiteSpace(b))
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < (a.Length > b.Length ? a.Length : b.Length); i++)
            {
                if (i < a.Length)
                {
                    c += a[i];
                }
                if (i < b.Length)
                {
                    c += b[i];
                }
            }
            return c;
        }

        public static string ToLowerCase(string a)
        {
            string upperCharacter = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            foreach (char ch in upperCharacter.ToCharArray())
            {
                a = a.Replace(ch, (char)(ch + 32))
                    .Replace('À', 'à')
                    .Replace('É', 'é')
                    .Replace('È', 'è')
                    .Replace('Ç', 'ç');
            }
            return a;
        }

        public static string Voyelles(string a)
        {
            string result = "";

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 'a' || a[i] == 'A' || a[i] == 'e' || a[i] == 'E' || a[i] == 'i' || a[i] == 'I' || a[i] == 'o' || a[i] == 'O' || a[i] == 'u' || a[i] == 'U' || a[i] == 'y' || a[i] == 'Y')
                {
                    if (!result.Contains(a[i]))
                    {
                        result += a[i];
                    }
                    result = ToLowerCase(result);
                }
            }
            return result;
        }

        public static string UnBazardString(string input)
        {
            string output = "";
            int midValue = (input.Length + 1) / 2;

            for (int i = 0; i <= midValue - 1; i++)
            {
                output = output + input[i] + input[i + midValue];
            }
            return output;
        }

        public static string ToCesarCode(string input, int offset)
        {
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    result += (char)('a' + (input[i] - 'a' + offset) % 26);
                }
                else if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    result += (char)('A' + (input[i] - 'A' + offset) % 26);
                }
                else
                {
                    result += input[i];
                }
            }
            return result;
        }
    }
}
