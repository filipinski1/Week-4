using System;

namespace Week_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to test: ");
            string inputString = Console.ReadLine();
            Program program = new Program();

            int countWordsWith4OrMoreLetters = program.CountWordsWith4OrMoreLetters(inputString);
            Console.WriteLine($"Number of words with 4 or more letters: {countWordsWith4OrMoreLetters}");


            bool isPalindrome = program.IsPalindrome(inputString);

            if (isPalindrome)
            {
                Console.WriteLine($"{inputString} is a palindrome string.");
            }
            else
            {
                Console.WriteLine($"{inputString} is not a palindrome string.");
            }
            int vowelCount = program.CountVowels(inputString);

            Console.WriteLine($"Number of vowels in the string: {vowelCount}");
            Console.WriteLine($"Bye");
        }

        public int CountWordsWith4OrMoreLetters(string text)
        {
            int counter = 0;
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                if (word.Length >= 4)
                {
                    counter++;
                }
            }
            return counter;
        }

     

        public bool IsPalindrome(string text)
        {
            
            string reverse = string.Empty;

            int lenght = text.Length - 1;
            while (lenght >= 0)
            {
                reverse = reverse + text[lenght];
                lenght--;
            }
            return text == reverse;
        }
        public int CountVowels(string text)
        {
            text = text.ToLower();
            int count = 0;
            foreach (char character in text)
            {
                if (IsVowel(character))
                {
                    count++;
                }
            }
            return count;
        }
        static bool IsVowel(char c)
        {

            return "aeiou".Contains(char.ToLower(c));
        }

    }
  


}