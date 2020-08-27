using System;

namespace ArrayDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata();
            Console.WriteLine(kata.ArrayDiff(new int[] { 1, 2, 2, 2, 3 }, new int[] { 2 }));
            Console.ReadLine();
        }
    }
}
