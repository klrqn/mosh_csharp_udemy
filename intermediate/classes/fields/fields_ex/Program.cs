using System;
﻿using System.Collections.Generic;

namespace fields_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(007, "Bond");
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            
            Console.WriteLine(customer.Orders.Count);
            
            customer.Promote();
            
            Console.WriteLine(customer.Orders.Count); // bug! use readonly
            
        }
    }
}
