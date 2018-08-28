 using System;

namespace constructorsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Id = 345;
            customer.Name = "hello";
            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);
        }
    }
}
