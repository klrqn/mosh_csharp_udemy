using System;

namespace okTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a valid time (24:00 Format): ");
            var input = Console.ReadLine();
            
            Console.WriteLine("This Time is Valid: {0}", IsValidTime(input));
        }
        
        static bool IsValidTime(string time)
        {
            
            if (time.IndexOf(':') != 2 || time.Length != 5)
                    return false;
                    
            var splitTime = time.Split(':');
            var hours = Convert.ToInt32(splitTime[0]);
            var minutes = Convert.ToInt32(splitTime[1]);
            
            if (hours > 24 || hours < 0)
                return false;
                
            if (minutes > 60 || minutes < 0)
                return false;
                
            if (hours == 24 && minutes != 00)
                return false;
                
            return true;
        }
    }
}
