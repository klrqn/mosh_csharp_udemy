using System;
﻿using System.Collections.Generic;

namespace fields_ex
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>(); //readonly should be initiailzed only once
        
        public Customer(int id)
        {
            this.Id = id;
        }
        
        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
        
	        public void Promote()
	    {
	        Orders = new List<Order>();
	        // ....        
	    }
    
    }
}