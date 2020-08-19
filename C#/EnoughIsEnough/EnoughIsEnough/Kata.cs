using System;
using System.Collections.Generic;
using System.Text;

namespace EnoughIsEnough
{
    public class Kata
    {
        public int[] EnoughIsEnough (int[] nums, int limit)
        {
            int counter = 0;
            List<int> oldNums = nums
            List<int> newNums = new List<int>();

            for(int i = 0; i < nums.Length; i++)
            {
                foreach(int num in nums)
                {
                    if(nums[i] == num && counter < limit)
                    {
                        newNums.Add(num);
                        counter++;
                    }
                }

                nums.Remove
            }
        }
    }
}
