using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
            text.Duplicate();


            System.Console.WriteLine("hello world");
        }
    }
}
