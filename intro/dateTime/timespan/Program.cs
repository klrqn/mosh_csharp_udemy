using System;

namespace timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var timeSpan = new TimeSpan(1, 2, 3);

            // // these do the same thing
            // var timeSpan1 = new TimeSpan(1, 0, 0); // hours, minutes, seconds
            // var timeSpan2 = TimeSpan.FromHours(1)

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);

            System.Console.WriteLine("duration: " + (start - end));

            System.Console.WriteLine("Minutes: " + timeSpan.Minutes); // 2
            System.Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes); // 60 + 2 + .05

            // timespan is immutable. 

            //add
            System.Console.WriteLine("add ex: " + timeSpan.Add(TimeSpan.FromMinutes(8)); // add 8 minutes.

            //subtract
            System.Console.WriteLine("add ex: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)); // subtract 2 minutes from timespan

            // to string
            Console.WriteLine("ToString" + timeSpan.ToString());

            // parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("09:02:30")); // returns a timespan object from a string.


        }
    }
}
