using System;
﻿using System.Collections.Generic;


namespace numbersUniqueHyphen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few numbers separated by a hyphen: ");
            var input = Console.ReadLine();

            UniqueNumbers(input);

        }
        
        public static List<int> UniqueNumbers(string numbers)
        {
            if (String.IsNullOrWhiteSpace(numbers))
            {
                return;
            }
                
            var numbersArray = numbers.Split('-');
            var uniqueList = new List<int>();
            
            foreach (var i in numbersArray)
            {
                var num = Convert.ToInt32(i);
                if (!uniqueList.Contains(num))
                    uniqueList.Add(num);
            }
            
            Console.Write("Unique Numbers: ");
            foreach (var j in uniqueList)
                Console.Write("{0} ", j);
            
        }
    }
}
