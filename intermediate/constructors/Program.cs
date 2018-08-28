 using System;

namespace constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);
        }
    }
}
