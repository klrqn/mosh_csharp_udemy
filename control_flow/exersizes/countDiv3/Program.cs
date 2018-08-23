using System;

namespace countDiv3
{
    static class Constants
    {
        public static int min = 1;
        public static int max = 100;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (var i = Constants.min; i <= Constants.max; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine(string.Format("Numbers between {0} and {1} that are divisible by 3: {2}",
                                            Constants.min, Constants.max, count));
        }
    }
}
