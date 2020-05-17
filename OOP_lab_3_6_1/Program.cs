using System;

namespace OOP_lab_3_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            str = str.ToLower();

            Console.WriteLine("\n{0}", str);

            string[] words = str.Split(new char[] { '\n', '\r', ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*', '/', '|' }, StringSplitOptions.RemoveEmptyEntries);

            string longestWord = words[0];

            foreach (string word in words)
            {
                if (longestWord.Length < word.Length)
                {
                    longestWord = word;
                }
            }

            Console.WriteLine("\nНайдовше слово: {0}", longestWord);
        }
    }
}
