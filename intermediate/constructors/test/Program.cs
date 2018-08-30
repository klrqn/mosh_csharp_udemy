using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var me = new Person("Scott", 32, "Cranston");

            // me.name = "Scott";
            // me.age = 33;
            // me.sex = 'M';
            // me.location = "Cranston";

            Console.WriteLine("Hi, my name is {0}, I am {1} and I live in {2}",
                                me.age, me.sex, me.location);

        }
    }
}
