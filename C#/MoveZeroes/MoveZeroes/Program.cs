using System;

namespace MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata();
            
            int[] newArray = kata.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });

            foreach(int num in newArray)
            {
                Console.Write($"{num} ");
            }

            Console.ReadLine();
        }

        /* Write an algorithm that takes an array and moves all of the zeros to the end, 
         * preserving the order of the other elements.*/
    }
}
