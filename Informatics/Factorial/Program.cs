using System;

class Program
{
    static void Main()
    {
        Console.Write("Input a number: ");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("Factorial of {0} is {1}", input, Fact(input));
    }
    static int Fact(int number)
    {
        if (number == 1)
            return 1;
        else
            return number * Fact(number - 1);
    }
}