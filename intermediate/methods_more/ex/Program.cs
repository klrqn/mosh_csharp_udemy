using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            UsePoints();
            UseParams();    
            
            // int.Parse("abc");
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion Failed");
        }
        
        static void UseParams()
        {
            var calc = new Calculator();
            Console.WriteLine(calc.Add(1,2));
            Console.WriteLine(calc.Add(1,2,3));
            Console.WriteLine(calc.Add(1,2,200,400));
            Console.WriteLine(calc.Add(new int[] {1, 2, 3, 4, 5 }));
        }        
        
        static void UsePoints()
        {
            try
            {
                var pt = new Point(10,20);
                
                pt.Move(5, 5);                  // first overload of method move
                pt.Move(new Point(10, 20));     // second overload of method move
                pt.Move(null);                  
                
                Console.WriteLine("x: {0}, y: {1}", pt.X, pt.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurred");
            }            
        }
    }
}
