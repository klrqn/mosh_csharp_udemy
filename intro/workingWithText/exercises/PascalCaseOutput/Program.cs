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
            
            PascalPhrase(input);
        }
        
        static string PascalPhrase(string input)
        {
            var pascalPhrase = "";
            foreach (var word in input.Split(' '))
            {
                var pascalWord = char.ToUpper(word[0])
                               + word.ToLower().Substring(1);
                pascalPhrase += pascalWord;
            }
            
            Console.WriteLine("{0}", pascalPhrase);           
            return pascalPhrase;
        }
    }
}
