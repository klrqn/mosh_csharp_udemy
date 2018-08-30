fields are: a variable we define at the class level
			used to store information about the class

==Initialization==

public class Customer
{
	List<Order> Orders;
	
	public Customer() // default / parameterless constructor
	{
		Orders = new List<Order>(); // initialize field
	}
}
// this works the same as above.
public class Customer
{
	List<Order> Orders = new List<Order>;
}

// Read-only fields
public class Customer
{
	readonly List<Order> Orders = new List<Order>;
} // why do we need this? SAFETY. ROBUSTNESS. 