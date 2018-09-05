== Agenda ==
- Signature of Methods
	 Name
	 Number and Type of Parameters
- Method Overloading
- Params modifier

public class Point
{
	public void Move(int x, int y) {} //signature = Move, 2 int params
	
	public void Move(Point newLocation) {} // signature: Move, 1 point param
	
	public void Move(Point newLocation, int speed) {}
} //3 overloads. 

public class Calculator
{
	public int Add(int n1, int n2) {}
	public int Add(int n1, int n2, int n3) {}
	public int Add(int n1, int n2, int n3, int n4) {}
} // 3 overloads again - not efficient though! CODE SMELLS

public class Calculator
{
	public int Add(int[] numbers) {} // this does the same thing as above..
}

public class Calculator
{
	public int Add(params int[] numbers) {} //when you may need a varying number of 
}

var result = calculator.Add(new int[]{ 1, 2, 3, 4, 5 });
var result = calculator.Add( 1, 2, 3, 4, 5 ); // using params

====================================
- Ref modifier [BAD]
public class Weirdo
{
	public void DoaWeirdThing(ref a)
	{
		a += 2;
	}
}
var  a = 1;
weirdo.DoaWeirdThing(ref a); // 3

- Out Modifier [BAD] // return multiple values
public class MyClass
{
	public void MyMethod(out int result)
	{
	result = 1;
	}
} 

int a;
myClass.MyMethod(out a)