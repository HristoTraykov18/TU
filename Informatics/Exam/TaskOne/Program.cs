using System;
using System.IO;

namespace TaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            /* #TODO
             * Create a program that gets a file name from the user, reads a single dimensional array 
             * (with integers divided by spaces) from the file and:
             * 1. Checks if the array is sorted (each element is smaller or equal to the one before).
             * 2. Are there triples of numbers in the array and how many.
             */
            try
            {
                string fileName = Console.ReadLine();
                string fileToRead = File.ReadAllText(fileName);
                int otherSymbols = 0;
                bool lastWasDigit = false;
                for (int i = 0; i < fileToRead.Length; i++) // Check if there are spaces or two- (or more) digit numbers
                {
                    if (fileToRead[i] >= '0' && fileToRead[i] <= '9')
                    {
                        lastWasDigit = true;
                    }
                    if (lastWasDigit && fileToRead.Length > i + 1 && (fileToRead[i] == ' ' || fileToRead[i + 1] >= '0' && fileToRead[i + 1] <= '9')) // Check if any of the symbols (space, dot, comma) or if there are two- (or more) digit numbers
                    {
                        otherSymbols++;
                        lastWasDigit = false;
                    }
                }

                int[] array = new int[fileToRead.Length - otherSymbols];
                int encounteredSpaces = 0;
                for (int i = 0; i < array.Length; i++)  // Go through each element of the array
                {
                    if (fileToRead[i + encounteredSpaces] == ' ')
                    {
                        i--;
                        encounteredSpaces++;
                        continue;
                    }
                    else if (i + encounteredSpaces < fileToRead.Length && fileToRead[i + encounteredSpaces] >= '0' && fileToRead[i + encounteredSpaces] <= '9') // Check if the number is digit
                    {
                        if (i + encounteredSpaces + 1 < fileToRead.Length && fileToRead[i + encounteredSpaces + 1] >= '0' && fileToRead[i + encounteredSpaces + 1] <= '9') // If the number is two- (or more) digit add it to 'array[i]'
                        {
                            int firstNumber = fileToRead[i + encounteredSpaces] - 48;
                            int secondNumber = fileToRead[i + encounteredSpaces + 1] - 48;
                            array[i] = (firstNumber * 10) + secondNumber;
                            encounteredSpaces++;
                        }
                        else // Otherwise add a single-digit number to 'array[i]'
                        {
                            array[i] = fileToRead[i + encounteredSpaces] - 48;
                        }
                    }
                }

                bool isSorted = true;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i > 0 && array[i] > array[i - 1]) // Check if the current element is lower or equal to the last
                    {
                        Console.WriteLine("The array is not sorted!");
                        isSorted = false;
                        break;
                    }
                }

                if (isSorted)
                {
                    Console.WriteLine("The array is sorted!");
                }

                int triplesCount = 0;
                for (int i = 0; i < array.Length; i++) // Go through each element of the array and check if there are triples of the current number
                {
                    int coupleCount = 0;
                    for (int k = 0; k < array.Length; k++) 
                    {
                        if (i != k && array[i] == array[k])
                        {
                            coupleCount++;
                        }
                    }
                    if (coupleCount == 2)
                    {
                        triplesCount++;
                    }
                }
                triplesCount /= 3;
                Console.WriteLine($"The ammount of triples is {triplesCount}.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file does not exist!");
            }
        }
    }
}
