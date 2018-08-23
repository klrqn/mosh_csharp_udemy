using System;

namespace datetimeprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            
            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);
            Console.WriteLine(now.Second);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            System.Console.WriteLine(now.ToLongDateString());
            System.Console.WriteLine(now.toShortDateString());
            System.Console.WriteLine(now.ToLongDateString()));
            System.Console.WriteLine(now.ToShortTimeString());
            System.Console.WriteLine(now.toString("yyyy-MM-dd"));

            // google.
            

            
        }
    }
}
