
﻿using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Scott";
            String lastName = "Burton";    // string must be imported from the System Namespace
            string lastName2 = "Burton2";  // this is exactly the same as above
            
            Int32 i = 1;    // ?
            int j = 2;      // essentially the same
            
            var add = i + j;
            
            var fullname = firstName + " " + lastName + lastName2;
            var fullname2 = string.Format("my name is {0} {1}\n", firstName, lastName);
            Console.Write(fullname2);
            
            var names = new string[3] {"john", "jack", "mary"};
            var formattednames = string.Join(" - ", names);
            Console.Write(formattednames);
            Console.Write("\n");
            
            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\\textfile\nc:\\folder4\\folder5\n\n";
            Console.WriteLine(text);
            
            var text2 = @"Hi John
Look into the following paths
c:\path1\path2
c:\path3\path4";
// verbatim string @
            Console.WriteLine(text2);
            
            
        }
    }
}
