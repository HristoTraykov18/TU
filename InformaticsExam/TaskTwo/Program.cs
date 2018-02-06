using System;

namespace TaskTwo
{
    class Program
    {
        /* #TODO
         * Create a program that reads string from the user until it gets an empty line.
         * 1. Create function which counts the words (we accept that words are divided by space, dot or comma).
         * 2. Create function which checks if there are numbers in the text and counts them.
         * 3. Create a function which counts how many times each letter is seen in the text.
         */
        public static int WordsCounter(string text) // The function that counts the words
        {
            int numberOfWords = 1;
            char lastSymbol = ' ';
            for (int i = 0; i < text.Length; i++) // Check each character in the text
            {
                char symbol = text[i];
                if ((symbol == ' ' || symbol == '.' || symbol == ',') && lastSymbol != ' ' && lastSymbol != '.' && lastSymbol != ',') // Increase 'numberOfWords' if there is a space, dot or comma
                {
                    numberOfWords++;
                }
                if (i == text.Length - 1 && (symbol == ' ' || symbol == '.' || symbol == ',')) // Check if any of the symbols (space, dot, comma) are used more than once and decrease 'numberOfWords' if needed
                {
                    numberOfWords--;
                }
                lastSymbol = symbol;
            }
            return numberOfWords;
        }
        public static int NumbersCounter(string text) // The function that counts the numbers
        {
            int numbersCount = 0;
            char lastSymbol = ' ';
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                if (symbol >= '0' && symbol <= '9')
                {
                    numbersCount++;
                }
                else
                {
                    lastSymbol = symbol;
                }
                if (lastSymbol >= '0' && lastSymbol <= '9') // Check if the number is two- (or more) digit and if it is - do not increase 'numbersCount'
                {
                    numbersCount--;
                }
                lastSymbol = symbol;
            }
            return numbersCount;
        }
        public static void NumberOfEachLetter(string text) // The function that counts letters
        {
            for (int i = 0; i < 26; i++) // Loop for each letter
            {
                int letterCount = 0;
                char letter = (char)('a' + i);
                foreach (char symbol in text)
                {
                    if (Char.ToLower(symbol) == letter)
                    {
                        letterCount++;
                    }
                }
                Console.WriteLine($"{letter}: {letterCount}");
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string text = "";
            while (input.Length != 0)
            {
                text += input;
                input = Console.ReadLine();
            }
            Console.WriteLine("Number of words: " + WordsCounter(text));
            Console.WriteLine("Numbers in text: " + NumbersCounter(text));
            NumberOfEachLetter(text);
        }
    }
}
