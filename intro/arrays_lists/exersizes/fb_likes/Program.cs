using System;
﻿using System.Collections.Generic;

namespace fb_likes
{
    class Program
    {
        static void Main(string[] args)
        {
            var friend = "";
            var friendsList = new List<string>();
            do
            {
                Console.Write("Enter a friend <enter> to finish: ");
                friend = Console.ReadLine();
                friendsList.Add(friend);
            }
            while (friend != "");
            
            var count = friendsList.Count - 1; // extra last empty 'friend'
            // Console.WriteLine(count);
            
            if (count == 1)
                Console.WriteLine("{0} likes your post", friendsList[0]);
            if (count == 2)
            {
                Console.WriteLine("{0} and {1} like your post", 
                friendsList[0], friendsList[1]);
            }
            if (count > 2)
            {
                Console.WriteLine("{0} and {1} and {2} others like your post", 
                friendsList[0], friendsList[1], count-2);
            }
        }
    }
}
