using System;
﻿using System.Collections.Generic;

namespace demoLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            
            numbers.AddRange(new int[3] { 5, 6, 7 });            
            // create a list, initialize it ahead of time
            // add one or multiple to list
            
            foreach (var n in numbers)
                Console.WriteLine(n);
                
            Console.WriteLine("index of 1:      " + numbers.IndexOf(1));
            Console.WriteLine("last index of 1: " + numbers.LastIndexOf(1));
            
            Console.WriteLine("count: " + numbers.Count);
            
            // removes the first instance of 1
            // numbers.Remove(1);
            
            // remove all instances of 1
            // foreach (var n in numbers)
            // {
            //     if (n == 1)
            //         numbers.Remove(n);
            // }
            // unhandled exception - collection was modified
            // not allowed to modify collection inside a foreach.
            
            
        for (var i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == 1)
                numbers.Remove(numbers[i]);
        }
        // removed both 1's from list
        
        numbers.Clear(); // removes everything from list. Count = 0;
            
            Console.WriteLine("Hello World!");
        }
    }
}


// GET RESHARPER for VS