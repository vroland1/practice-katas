using System;
using System.Collections.Generic;
using System.Text;

namespace DuplicateEncode
{
    public class Kata
    {
        public string DuplicateEncode(string word)
        {
            int frequency = 0;
            string newString = "";
            word = word.ToLower();

            for (int i = 0; i < word.Length; i++)
            {

                for (int j = 0; j < word.Length; j++)
                {
                    if (word[i] == word[j])
                    {
                        frequency++;
                    }
                }

                newString = (frequency == 1) ? newString + "(" : newString = newString + ")";

                frequency = 0;
            }

            return newString;
        }
    }
}
