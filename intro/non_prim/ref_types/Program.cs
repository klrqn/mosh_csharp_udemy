using System;

namespace ref_types
{
    public class Person
    {
        public int Age;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a; // copy of value passed to b
            b++;
            
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));
            
            var arr1 = new int[3] {1, 2, 3};
            var arr2 = arr1; // copied by reference! Pointers!
            
            arr2[0] = 0;
            Console.WriteLine(string.Format("arr1[0]: {0},  arr2[0]: {1}", arr1[0], arr2[0]));
            
            // ==================== Person Ex. Below ==========================================
            
            var number = 1;
            Increment(number); // this takes a copy ... scope ... doesn't change number
            Console.WriteLine(number); // BY VALUE TYPE
            
            var person = new Person() {Age = 20};
            MakeOld(person);    // BY REFERENCE TYPE
            Console.WriteLine(person.Age); 
            
            
            
        }
        
        public static void Increment(int number)
        {
            number += 10;
        }
        
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
