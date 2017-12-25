using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixChecks
{
    class Program
    {
        static decimal ReadDecimal()
        {
            bool valid;
            decimal input;
            do
            {
                valid = decimal.TryParse(Console.ReadLine(), out input);

                if (!valid)
                    Console.WriteLine("Please enter a decimal number");
            }
            while (!valid);

            return input;
        }
        static decimal[,] MatrixInput()
        {
            Console.WriteLine("Number of rows and columns: ");
            int n = int.Parse(Console.ReadLine());
            decimal[,] matrix = new decimal[n, n];
            Console.WriteLine("Enter numbers in the matrix");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Row " + (i + 1) + ": ");
                string r = Console.ReadLine();
                string[] c = r.Split();
                for (int k = 0; k < n; k++)
                {
                    matrix[i, k] = decimal.Parse(c[k]);
                }
            }
            return matrix;
        }
        static void BiggestNumber(decimal[,] matrix)
        {
            decimal sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine("The sum of the main diagonal is " + sum);
        }
        static void SmallestNumber(decimal[,] matrix)
        {
            decimal smallestNumber = decimal.MaxValue;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, matrix.GetLength(0) - i - 1] < smallestNumber)
                    smallestNumber = matrix[i, matrix.GetLength(0) - i - 1];
            }
            Console.WriteLine("The smallest number in the secondary diagonal is " + smallestNumber);
        }
        static void IsDiagMatrix(decimal[,] matrix)
        {
            bool isDiagonal = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    if (matrix[i, k] != 0 & i != k)
                    {
                        isDiagonal = !isDiagonal;
                        break;
                    }
                }
            }
            if (isDiagonal)
                Console.WriteLine("The matrix is diagonal!");
            else
                Console.WriteLine("The matrix is not diagonal!");
            Console.WriteLine(); ;
        }
        static void Main(string[] args)
        {
            int userChoice = 10;
            decimal[,] matrix = null;
            while (userChoice != 0)
            {
                Console.WriteLine("\nChose an option: ");
                Console.WriteLine("1 - Enter matrix");
                Console.WriteLine("2 - Main diagonal sum");
                Console.WriteLine("3 - Smallest number in secondary diagonal");
                Console.WriteLine("4 - Check for diagonal matrix");
                Console.WriteLine("0 - Exit the program");
                userChoice = int.Parse(Console.ReadLine());
                if (userChoice == 1)
                {
                    matrix = MatrixInput();
                }
                else if (userChoice == 2)
                    BiggestNumber(matrix);
                else if (userChoice == 3)
                    SmallestNumber(matrix);
                else if (userChoice == 4)
                    IsDiagMatrix(matrix);
                else
                    Console.WriteLine("\nEnter a valid choice!");
            }
            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }
    }
}
