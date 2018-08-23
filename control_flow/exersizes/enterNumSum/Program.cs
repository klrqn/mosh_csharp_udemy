using System;

namespace enterNumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            var input = "";
            
            do
            {
                Console.Write("Enter a number: ");
                input = Console.ReadLine();
                if (input.ToLower() != "ok")
                    sum += Convert.ToInt32(input);
                // Console.WriteLine("Total: {0}", sum);
            }
            while (input.ToLower() != "ok");
            
            Console.WriteLine("Total: {0}", sum);
            
        }
    }
}
