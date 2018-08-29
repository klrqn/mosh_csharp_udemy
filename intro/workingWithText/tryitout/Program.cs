using System;

namespace tryitout
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var fullName = "Scott Burton ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            System.Console.WriteLine("First Name: " + firstName);
            System.Console.WriteLine("Last Name: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

            var newName = fullName.Replace("Scott", "Scottie Pippen Yo");
            System.Console.WriteLine(newName);

            if (String.IsNullOrEmpty(" ".Trim()))
                System.Console.WriteLine("invalid String");
                
        }
    }
}
