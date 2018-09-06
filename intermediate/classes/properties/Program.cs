using System;

namespace properties
{
    
    public class Person
    {
        // prop
        public string Name { get; set; }
        // prop
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; } // 'private' cannot be changed 

        public Person(Datetime birthdate)
        {
            Birthdate = birthdate;
        }
        
        // calculated properties on the bottom
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                
                return years;
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(DateTime(1985,1,1,));
            Console.WriteLine(person.Age);
            
        }
    }
}

// TOOLS / EXTENSIONS AND UPDATES / ONLINE
// PRODUCTIVITY POWER TOOLS
// YOU GET 'OPEN COMMAND PROMPT'
// TAKES YOU DIRECTLY TO THE PROJECT.

// cd bin/Debug
// ildasm properties.exe - intermediate language disassemble