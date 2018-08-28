using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();
            
            Calculator calc = new Calculator();
            var result = calc.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
