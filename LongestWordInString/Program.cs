using System;

namespace LongestWordInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "This is a test sentence for my new program.";
            Console.WriteLine(input);
            Console.WriteLine(FindLongestWord(input));
            Console.ReadKey();
        }


        static string FindLongestWord(string input)
        {
            string[] words = input.Split(" ", StringSplitOptions.None);
            string longestWord = "";
            foreach(string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            return longestWord;
        }
    }
}
