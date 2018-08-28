using System;

namespace largerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another: ");
            var number2 = Convert.ToInt32(Console.ReadLine());
            
            var larger = (number1 > number2) ? number1 : number2;
            Console.WriteLine("The larger of the two: {0}", larger);
            
        }
    }
}
