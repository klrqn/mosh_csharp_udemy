using System;

namespace PascalCaseOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few words: ");
            var input = Console.ReadLine();
            
            if (String.IsNullOrEmpty(input))
                return;
            
            var pascalPhrase = "";
            foreach (var word in input.Split(' '))
            {
                var pascalWord = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                pascalPhrase += pascalWord;
            }
            
            Console.WriteLine("{0}", pascalPhrase);
            
        }
    }
}
