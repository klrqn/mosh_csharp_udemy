using System;

namespace stopwatch
{
    public class Stopwatch
    {
        private bool _started;
        private bool _stopped;
        private DateTime _startTime { get; set; }
        private DateTime _stopTime { get; set; }
        
        public Stopwatch()
        {
            this._started = false;
            this._stopped = true;
        }
        
        public void Start()
        {
            if (!_started)
            {
                Console.WriteLine("Starting...");
                _started = true;
                _stopped = false;
                _startTime = DateTime.Now;
                Console.WriteLine("Start Time: {0}", _startTime);
            }
            else if (_started == true)
                throw new InvalidOperationException("Cannot Start Stopwatch Again");
        }
        
        public void Stop()
        {
            Console.WriteLine("_stopped variable = {0}", _stopped);
            if (_stopped == false)
            {
                Console.WriteLine("Stopping...");
                _started = false;
                _stopped = true;
                _stopTime = DateTime.Now;
                Console.WriteLine("Stop Time: {0}", _stopTime);
            }
            Console.WriteLine("Total Time Between Start and Stop: {0}", _stopTime - _startTime);
        }
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {   var stopwatch = new Stopwatch();
                Console.Write("Enter \"start\" or \"stop\" (q to quit)... ");
                var input = Console.ReadLine();
                if (input.ToLower() == "start")
                {
                    stopwatch.Start();
                    continue;
                }
                else if (input.ToLower() == "stop")
                {
                    stopwatch.Stop();
                    continue;
                }
                else if (input.ToLower() == "quit" || input.ToLower() == "q")
                    break;               
            }
        }
    }
}
