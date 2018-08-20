using System;

namespace firstprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 1;
            int count = 10;
            float totalPrice = 25.50f;
            char character = 'A';
            string firstName = "Scott";
            bool isWorking = true;

            Console.WriteLine(number);
            System.Console.WriteLine(count);
            System.Console.WriteLine(totalPrice);
            System.Console.WriteLine(character);
            System.Console.WriteLine(firstName);
            System.Console.WriteLine(isWorking);

            var thisIsEasier = "easier variable naming";

            System.Console.WriteLine(thisIsEasier);



        }
    }
}

// dotnet run