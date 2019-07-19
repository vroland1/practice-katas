using System;
using System.Collections.Generic;
using System.Text;

namespace FindOddInt
{
    public class Kata
    {
        public int findIt(int[] seq)
        {
            int count = 0;
            int answer = 0;

            for (int i = 0; i < seq.Length; i++)
            {
                for (int j = 0; j < seq.Length; j++)
                {
                    if (seq[i] == seq[j])
                    {
                        count++;
                    }
                }

                if (count % 2 == 1)
                {
                    answer = seq[i];
                    break;
                }
            }

            return answer;
        }

    }
}

