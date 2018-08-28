// A Class is simply a building block of a software application

Presentation                =   PostView
Business Logic / Domain     =   PostView
Data Access / Persistence   = PostRepository

Inside a Class = DATA / METHODS || FUNCTIONS

UML - Unified Modified Language - 3 Parts - Name, Attributes, Methods

An Object is an instance of a class (that resides in memory)

// declare a class in C#
public class Presentation
{
    public string Name;

    public void Introduce()
    {
        System.Console.WriteLine("Hi, my name is" + Name);
    }

    // these do the same thing
    Person person = new Person();
    var person = new Person();

    person.Name = "Scott";  // instance member
    person.Introduce();     // instance member
}
// use Pascal Case to name classes in C#
// use camel Case when naming parameters in C#

Console.WriteLine("HELLO"); // STATIC member

// static members are used to represent concepts that are singleton. DateTime.
Declaring Static members ===
public class Person
{
    public static int PeopleCount = 0;
}