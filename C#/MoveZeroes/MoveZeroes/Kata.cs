using System;
using System.Collections.Generic;
using System.Text;

namespace MoveZeroes
{
    public class Kata
    {
        public int[] MoveZeroes(int[] arr)
        {
            int[] newArray = new int[arr.Length];
            int elementNonZero = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    newArray[elementNonZero] = arr[i];
                    elementNonZero++;
                }
            }

            return newArray;
        }
    }
}
