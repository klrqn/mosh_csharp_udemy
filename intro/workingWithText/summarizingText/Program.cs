using System;
﻿using System.Collections.Generic;

namespace summarizingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "this is going to be a really really really reall";
            var summary = StringUtility.SummarizeText(sentence, 30);
            Console.WriteLine(summary);
        }


    }
}
