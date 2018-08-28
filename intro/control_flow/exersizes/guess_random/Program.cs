using System;

namespace guess_random
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var secretNumber = rnd.Next(1,11);
            var guess = "";
            Console.WriteLine(secretNumber);
            
            // should have used a while loop
            for (var i = 0; i < 4; i++)
            {
                Console.Write("guess a number between 1 and 10: ");
                guess = Console.ReadLine();
                
                if (Convert.ToInt32(guess) == secretNumber)
                {
                    Console.WriteLine("Correct!");
                    break;
                }
            }
            if (Convert.ToInt32(guess) != secretNumber)
                Console.WriteLine("you suck!");
        }
    }
}
