using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // FILE STATIC
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp.myfile.jpg", true);  // true it's allowed to override

            if (File.Exists(path))
            {
                
            }

            var content = File.ReadAllText(path);

            // FILEINFO

            var fileinfo = @"c:\somefile.jpg";
            fileinfo.CopyTo("...")
            fileinfo.Delete();
            if (fileinfo.Exists)
            {
                //
            }



            Console.WriteLine("Hello World!");
        }
    }
}
