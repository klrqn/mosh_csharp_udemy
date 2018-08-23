using System;

namespace reverseName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your Name: ");
            var yourName = Console.ReadLine();
            
            var nameLength = yourName.Length;
            var nameArray = new char[nameLength];
            // Console.WriteLine("LENGTH: {0}", yourName.Length);
            
            for (var i = 0; i < nameLength; i++)
            {
                nameArray[i] = yourName[nameLength - 1 - i];
                Console.Write("- {0} - ", nameArray[i]);
            }
                
            var reversed = new string(nameArray); // ?
            
            Console.WriteLine("Your Name Reversed: {0}", reversed);
        }
    }
}
