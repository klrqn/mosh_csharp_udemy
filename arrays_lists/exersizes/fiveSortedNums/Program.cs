using System;
﻿using System.Collections.Generic;

namespace fiveSortedNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
        
        
            while (numbers.Count < 5)
            {
                Console.Write("Enter a unique number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("Number Written: {0}", number);
                if (numbers.Contains(number))
                    continue;
                numbers.Add(number);
            }
            
            numbers.Sort();
            
            foreach (var n in numbers)
                Console.Write(" {0}, " n);
        }
    }
}
