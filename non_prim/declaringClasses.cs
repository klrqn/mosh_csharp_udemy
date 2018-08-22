public class person
{
	public string Name;
	
	public void Introduce();
	{
		Console.Write("My name is {1}", Name);
	}
}

int number;

Person person = new Person();
// CLR takes care of deallocating memory
var person = new Person();

person.Name = "Scott";
person.Introduce();

// STATIC MODIFIER
public class Calculator
{
	public static int Add(int a, int b)
	{
		return a + b;
	}
}

int result = Calculator.Add(1, 2);
// static modifier when we only need a single instance in memory

class Program
{
	static void Main()
	{
		// only one method of Main! 
	}
}

// When you modify any members of a class (field or method) with static modifier, it will be accessible through the class only, not objects of that class type
// ie current_date_time
