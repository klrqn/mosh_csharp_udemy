using System;
using System.Collections.Generic;

namespace numbersHyphen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few numbers with hyphens in-between: ");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));
                // System.Console.WriteLine(number);

            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }

            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i-1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);

        }
    }
}
