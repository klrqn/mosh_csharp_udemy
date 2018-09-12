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

            var order = new Order();
            customer.Orders.Add(order);

            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);

            var customer2 = new Customer(1234, "john");
            System.Console.WriteLine(customer2.Id);
            System.Console.WriteLine(customer2.Name);

            
        }
    }
}
