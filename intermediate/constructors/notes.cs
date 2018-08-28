
a Constructor is ---
a method that is called when an instance of a class is created


// ex
public clsas Constumer
{
    public Customer() // Constructor. Same name as the Class! No Return Type
    {
        // initialization of object
    }
}

// ex
public clsas Customer
{
    public string Name;

    public Customer(string name) // Constructor
    {
        this.Name = name;
    }
}

var customer = new Customer("Name");

// Constructor Overloading
public class Customer{
    public Customer() { ... }
    public Customer(string name) { ... }
    public Customer(int id, string name) { ... }
} // makes initialization easier