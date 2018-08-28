using System;

namespace constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Id = 123;
            customer.Name = "scott";

            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);
        }
    }
}
