using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customContains
{
    internal static class Extensions
    {

        public static bool customContains(this string word, string str)
        {
            int index = 0;
            string test = "";
            bool result = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (test.Length == str.Length)
                {
                    result = true;
                    break;
                }   
                else if (word[i] == char.ToUpper(str[index]) || word[i] == char.ToLower(str[index]))
                {
                    test += word[i];
                    if (test.Length != str.Length)
                    {
                        index++;
                    }
                }
                else if (test.Length != str.Length)
                {
                    index = 0;
                    test = "";
                }
            }
            return result;            
        }

    }
}
