using System;

namespace stopwatch
{
    public class Stopwatch
    {
        public static bool started { get; set; }
        public static bool stopped { get; set; }
        public static DateTime startTime { get; set; }
        public static DateTime stopTime { get; set; }
        
        public static void Start()
        {
            if (!started)
            {
                started = true;
                stopped = false;
                startTime = DateTime.Now;
            }
            else if (started == true)
                throw new InvalidOperationException("Cannot Start Stopwatch Again");
        }
        
        public static void Stop()
        {
            if (stopped == false)
            {
                started = false;
                stopped = true;
                stopTime = DateTime.Now;
            }
            Console.WriteLine("Total Time Between Start and Stop: {0}", stopTime - startTime);
        }
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Write("Enter \"start\" or \"stop\" (q to quit)... ");
                var input = Console.ReadLine();
                if (input.ToLower() == "start")
                {
                    Stopwatch.Start();
                    continue;
                }
                else if (input.ToLower() == "stop")
                {
                    Stopwatch.Stop();
                    continue;
                }
                else if (input.ToLower() == "quit" || input.ToLower() == "q")
                    break;               
            }
        }
    }
}
