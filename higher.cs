using System;
using System.Collections.Generic;

namespace numberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
        Random rndm = new Random();
        int winNum = rndm.Next(1,100);
        bool win = false;

        do
        {
            Console.Write("Guess a number between 1-100:");
            string s = Console.ReadLine();

            int i = int.Parse(s);

            if (i > winNum)
            {
                Console.WriteLine("your number is too high! guess lower");
            }
            else if (i < winNum)
            {
                Console.WriteLine("your number is too low! guess higher");
            }
            else if (i == winNum)
            {
                Console.WriteLine("you win!");
                win = true;

            }
        } while (win == false);
    }
}
}
