using System;

namespace up_downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //upcasting 
            Circle circle = new Circle();
            Shape shape = circle; //implicit

            //downcasting 
            Circle anotherCircle = (Circle)shape; 

            // throws InvalidCastException
            Car car = (Car) shape;

            //use as keyword
            Car car = (Car) obj; //InvalidCastException

            Car car = obj as Car; //use as
            if (car != null)
            {
                // ... 
            }

            // or use is 
            if (obj is Car)
            {
                Car car = (Car) obj; 
            }


        }

    }
}
