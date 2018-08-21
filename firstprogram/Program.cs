using System;

namespace firstprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", byte.MaxValue, byte.MinValue);

            byte b = 1;
            int i = b;

            System.Console.WriteLine(i); 



            int n = 1;
            byte c = (byte) n;

            System.Console.WriteLine(c);

            try
            {
                string s = "true";
                bool boo = Convert.ToBoolean(s);
                System.Console.WriteLine(boo);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("error yo");
            }

            var number = "1234"; // could use string, but..var is coo
            // int i = (int) number;
            int f = Convert.ToInt32(number);

            System.Console.WriteLine(f);

        }
    }
}

// dotnet run
// ctrl + shift + b (build)