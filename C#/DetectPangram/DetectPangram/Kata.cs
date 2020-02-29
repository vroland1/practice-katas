using System;
using System.Collections.Generic;
using System.Text;

namespace DetectPangram
{
    public class Kata
    {
        public bool DetectPangram(string sentence)
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            bool pangram = true;

            foreach (char letter in alpha)
            {
                if (!sentence.ToLower().Contains(letter))
                {
                    pangram = false;
                    break;
                }
            }

            return pangram;
        }
    }
}
