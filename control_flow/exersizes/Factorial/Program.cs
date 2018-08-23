using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var factoral = 1;
            for (var i = 1; i <= input; i++)
                factoral *= i;
                
            Console.WriteLine("The Factoral of {0} is {1}", input, factoral);
        }
    }
}
