using System;

namespace access_modifiers
{
    public class Person
    {
        private DateTime _birthdate;
        
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        
        public DateTime GetBirthDate()
        {
            return _birthdate;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthDate(new DateTime(1985, 9, 15));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
===============================================
OOP
PRINCIPLE OF ENCAPSULATION
OBJECTS SHOULD HIDE THEIR IMPLEMENTATION DETAIL 
AND
REVEAL WHAT THEY CAN DO (AS OPPOSED TO HOW)
===============================================