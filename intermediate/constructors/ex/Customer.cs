using System.Collections.Generic; // for lists

namespace constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders; // always initialize to an empty list


        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}