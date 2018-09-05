using System;

namespace codeEx
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            System.Console.WriteLine("Hi {0}, I am {1}", to, Name); // format string
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Scott";
            person.Introduce("Mosh");

            var p = Person.Parse("John Doe"); // static
            p.Introduce("Somebody Else");

            
        }
    }
}
