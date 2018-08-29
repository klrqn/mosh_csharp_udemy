using System;
﻿﻿using System.Collections.Generic;

namespace list_smallest3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] splitInput;
            
            while (true)
            {
                Console.Write("Enter a csv list: ");
                var input = Console.ReadLine();
            
                if (!String.IsNullOrWhiteSpace(input))
                {
                    splitInput = input.Split(',');
                    if (splitInput.Length > 4)
                        break;
                }
                Console.WriteLine("Invalid List");
            }
            // foreach (var n in splitInput)
            //     Console.Write("{0} ", n);
                
            var numbers = new List<int>();
            foreach (var n in splitInput)
                numbers.Add(Convert.ToInt32(n));
            
            // for (var i = 0; i < numbers.Count; i++)
            //     Console.Write("- {0} -", numbers[i]);
                
            var smallest = new List<int>();
            while (smallest.Count < 3)
            {
                var min = numbers[0];
                foreach (var n in numbers)
                {
                    if (n < min)
                        min = n;
                }
                    
                smallest.Add(min);
                    
                numbers.Remove(min);
            }
            Console.WriteLine("3 smallest: {0} {1} {2}", 
                                            smallest[0], 
                                            smallest[1], 
                                            smallest[2]);
        }
    }
}
