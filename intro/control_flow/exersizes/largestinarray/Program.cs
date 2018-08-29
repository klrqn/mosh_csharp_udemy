using System;

namespace largestinarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an Array separated by commas!: ");
            var input = Console.ReadLine();
            
            string[] split = input.Split(new Char[] {',', ' '});
            // for (each in split)
            // Console.WriteLine(split[0]);
            // Console.WriteLine(split[1]);
            // Console.WriteLine(split[2]);
            // Console.WriteLine(split[3]);
            // Console.WriteLine(split[4]);
            
            var max = Convert.ToInt32(split[0]);
            
            foreach (var num in split)
            {
                var number = Convert.ToInt32(num);
                if (number > max)
                {
                    max = number;
                }
                
            }
            
            Console.WriteLine("Max: {0}", max);
        }
    }
}
