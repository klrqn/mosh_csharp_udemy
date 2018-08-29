using System;

namespace demoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };
            Console.WriteLine(numbers.Length); // 6
            
            // IndexOf()
            var index = Array.IndexOf(numbers, 9); // 2
            Console.WriteLine(index); // 2
            
            // clear 2 elements in array
            Array.Clear(numbers, 0, 2);
            foreach (var n in numbers)
                Console.WriteLine(n);
                
            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3); // copy first 3 elements of numbers array to another array
            foreach (var n in another)
                Console.WriteLine(n);
                
            Array.Sort(numbers);
            Console.WriteLine("effect of sort: ");
            foreach (var n in numbers)
                Console.WriteLine(n);
                
            // Reverse()
            Array.Reverse(numbers();
             
        }
        
        
    }
}
