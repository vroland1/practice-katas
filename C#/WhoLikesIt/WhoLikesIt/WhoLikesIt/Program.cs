using System;

namespace WhoLikesIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata();
            Console.WriteLine(kata.WhoLikesIt(new string[] {"Mark", "Chelsea", "Cole"}));
            Console.ReadLine();
        }
    }
}
