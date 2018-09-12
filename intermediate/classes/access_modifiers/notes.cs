ACCESS MODIFIERS
there are 5 access modifiers

- public

- private

- protected

- internal

- protected internal

A way to control access to a class and/or its members
to create safety in our programs.


// ex
public class Customer
{
	private string Name;
}

var john = new Customer();
john.Name = "john" // won't compile.

ENCAPSULATION
each class is only responsible for one thing. 
hide details from the outside. 
= define fields as private
= provide getter/setter methods as public

// ex of encapsulation
public class Person
{
	// declared private
	private string _name; // private start with an underscore 
	
	public void SetName(string name)
	{
		if (!String.IsNullOrEmpty(name))
			this.Name = name;
	}
	
	public string GetName()
	{
		return Name
	}
}