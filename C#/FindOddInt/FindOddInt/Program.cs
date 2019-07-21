using System;

namespace FindOddInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata();
            Console.WriteLine(kata.FindIt(new int[] { 1, 21, 1, 45, 109, 21, 1, 109, 1, 45, 109 }));
            Console.ReadLine();
        }
    }

    /*  KATA INSTRUCTIONS:
     * 
     * Given an array, find the int that appears an odd number of times.

 There will always be only one integer that appears an odd number of times.*/

}
