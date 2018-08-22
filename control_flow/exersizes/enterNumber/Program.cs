using System;

namespace enterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            
            if (number < 1 || number > 10)
                Console.WriteLine("must be between 0 & 10");
            else
                Console.WriteLine("thanks!");
            
        }
    }
}
