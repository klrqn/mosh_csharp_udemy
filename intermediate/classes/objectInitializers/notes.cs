public class Person
{
    public int id;
    public string FirstName;
    public string LastName;
    public DateTime Birthdate;
}

// USING CONSTRUCTORS
public class Person
{
    public Person(int id) {}
    public Person(int id, string FirstName) {};
    public Person(int id, string FirstName, string LastName) {};
    public Person(int id, string FirstName, string LastName, DateTime birthdate) {};
}    // MESSY

object initializer -
a syntax for quickly initialising an object without the need to call one 
of its constructors

// USING OBJECT INITIALIZATION SYNTAX
var person = new Person
            {
                FirstName = "Scott",
                LastName = "Burton"
            };