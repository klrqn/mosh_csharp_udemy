using System;

namespace random_class
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
                // Console.WriteLine(rnd.Next() % 100);
                // Console.Write((char)rnd.Next(97, 122));
                // Console.Write((char)( 'a' + rnd.Next(0, 26)));
                buffer[i] = (char)('a' + rnd.Next(0, 26));
                
            // var password = "";
            var password = new string(buffer);
            
            Console.WriteLine(password);
            // Console.WriteLine((int) 'a');
        }
        
        
        
        
    }
}
