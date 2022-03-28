using System;

namespace _28._03_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Sentence = "Hello World";
            Console.WriteLine(Sentence);
            Console.WriteLine("Duzgundur?");
            Console.WriteLine(FindWords(Sentence));
            string Sentence1 = "blue sky";
            Console.WriteLine(Sentence1);
            Console.WriteLine("Duzgundur?");
            Console.WriteLine(FindWords(Sentence1));


        }
        public static bool FindWords(string word)
        {
            bool Check = false;
            bool firstBigWord = false;
            bool secondBigWord = false;
            string[] words = word.Split();
            if (words.Length == 2)
            {
                string firstWord = words[0];
                string secondWord = words[1];
                if (firstWord[0] == char.ToUpper(firstWord[0]))
                    {
                    firstBigWord = true;
                }

                if (secondWord[0] == char.ToUpper(secondWord[0]))
                {
                    secondBigWord = true;
                }
            }
            Check = firstBigWord && secondBigWord;
            return Check;
        }
    }
}
