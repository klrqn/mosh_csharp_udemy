using System;
﻿using System.Collections.Generic;

namespace vowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an english word: ");
            var input = Console.ReadLine();
            
            if (String.IsNullOrWhiteSpace(input))
                return;
            
            var inputLower = input.ToLower();
            var vowels = new List<char>() {'a', 'e', 'i', 'o', 'u'};
            var vowelCount = 0;
            
            foreach (var vowel in vowels)
                vowelCount += ContainsHowMany(vowel, inputLower);
            
            Console.WriteLine("\"{0}\" contains {1} vowels", input, vowelCount);
            return;
        }
        
        static int ContainsHowMany(char c, string str)
        {
            var count = 0;
            for (var i = 0; i < str.Length; i++)
            {
                if (c == str[i])
                    count++;
            }
            Console.WriteLine("{0}", count);
            return count;
            
        }
        
    }
}
