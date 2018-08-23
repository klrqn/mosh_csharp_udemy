
﻿using System;
﻿using System.Collections.Generic;

namespace listofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            
            while (true)
            {
                Console.Write("Enter a number (\"Quit\" to exit): ");
                var number = Console.ReadLine();
                // Console.WriteLine("Number Written: {0}", number);
                if (number == "Quit" || String.IsNullOrWhiteSpace(number))
                    break;
                numbers.Add(Convert.ToInt32(number));
            }
            
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }
            
            Console.WriteLine("Unique Numbers: ");
            foreach (var n in uniques)
                Console.Write("{0}, ", n);
            Console.WriteLine();
        }
    }
}
