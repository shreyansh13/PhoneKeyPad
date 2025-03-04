using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneKeyPad
{
    public class PhoneProcessor
    {
        
        public static String OldPhonePad(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            Dictionary<string, char> map = Initialize();
            int i = 0;

            StringBuilder output = new StringBuilder();

            while (input[i] != '#')
            {
                if (input[i] == '*')
                {
                    if (output.Length > 0)
                    {
                        output.Length--;
                    }
                    i++;
                }
                else if (input[i] == ' ')
                {
                    i++;
                }
                else
                {
                    string currentString = string.Empty;
                    currentString = GetNextSameChars(input, i);
                    i += currentString.Length;

                    if (map.TryGetValue(currentString, out char currentChar))
                    {
                        output.Append(currentChar);
                    }                                        
                }
            }
            return output.ToString().ToUpper();
        }

        private static string GetNextSameChars(string input, int index)
        {
            char startChar = input[index];
            string currentString = string.Empty;
            while (index < input.Length && input[index] != '#' && input[index] == startChar && input[index] != ' ')
            {
                currentString += input[index];
                index++;
            }

            return currentString;
        }

        private static Dictionary<string, char> Initialize()
        {
            Dictionary<string, char> map = new Dictionary<string, char>()
            {
                { "2", 'a' },
                { "22", 'b' },
                { "222", 'c' },
                { "3", 'd' },
                { "33", 'e' },
                { "333", 'f' },
                { "4", 'g' },
                { "44", 'h' },
                { "444", 'i' },
                { "5", 'j' },
                { "55", 'k' },
                { "555", 'l' },
                { "6", 'm' },
                { "66", 'n' },
                { "666", 'o' },
                { "7", 'p' },
                { "77", 'q' },
                { "777", 'r' },
                { "7777", 's' },
                { "8", 't' },
                { "88", 'u' },
                { "888", 'v' },
                { "9", 'w' },
                { "99", 'x' },
                { "999", 'y' },
                { "9999", 'z' }
            };

            return map;
        }
    }
}
