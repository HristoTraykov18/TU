using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args[0].ToLower() == "-h" || args[0] == null)
                    ShowHelp();
                else if (args[0].ToLower() == "-g")
                {
                    try { GenerateFile(args[1]); }
                    catch (IndexOutOfRangeException) { GenerateFile(); }
                }
                else if (args[0].ToLower() == "-s")
                {
                    try { SortFile(args[1], args[2], args[3]); }
                    catch (IndexOutOfRangeException) { SortFile(args[1], args[2], "a"); }
                }
                else if (args[0].ToLower() == "-v")
                    ViewFileContent(args[1]);
                else if (args[0].ToLower() == "-d")
                    DeleteFile(args[1]);
                else
                    Console.WriteLine($"Invalid arguement \nUse -h for help");
            }
            catch (IndexOutOfRangeException) { ShowHelp(); }
        }

        static void DeleteFile(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
                Console.WriteLine($"{filename} successfuly deleted.");
            }
            else
                Console.WriteLine($"{filename} does not exist.");
        }

        static void GenerateFile(string filename = "generatedFile.txt")
        {
            if (!File.Exists(filename))
            {
                try
                {
                    using (FileStream fs = File.Open(filename, FileMode.CreateNew))
                    {
                        Random rand = new Random();
                        int num = rand.Next(-100, 101);
                        byte[] number = new UTF8Encoding(true).GetBytes(num.ToString());
                        byte[] newline = Encoding.ASCII.GetBytes(Environment.NewLine);

                        for (int i = 0; i < 5; i++)
                        {
                            fs.Write(number, 0, number.Length);
                            fs.Write(newline, 0, newline.Length);
                            num = rand.Next(-100, 101);
                            number = new UTF8Encoding(true).GetBytes(num.ToString());
                        }
                    }
                    Console.WriteLine($"Created {filename} and put some random numbers in it");
                }
                catch (IOException e) { Console.WriteLine("An errorr occured: " + e); }
            }
            else
            {
                Console.Write($"{filename} exists in the current directory. Do you want to override it? [Y/n]: ");
                string input = Console.ReadLine();
                if (input.ToLower() != "n")
                {
                    using (FileStream fs = File.Open(filename, FileMode.Truncate))
                    {
                        Random rand = new Random();
                        int num = rand.Next(-100, 101);
                        byte[] number = new UTF8Encoding(true).GetBytes(num.ToString());
                        byte[] newline = Encoding.ASCII.GetBytes(Environment.NewLine);

                        for (int i = 0; i < 5; i++)
                        {
                            fs.Write(number, 0, number.Length);
                            fs.Write(newline, 0, newline.Length);
                            num = rand.Next(-100, 101);
                            number = new UTF8Encoding(true).GetBytes(num.ToString());
                        }
                    }
                    Console.WriteLine($"{filename} has been overriden");
                }
                else
                    Console.WriteLine("Operation canceled");
            }
        }

        static void ShowHelp()
        {
            Console.WriteLine("p1.exe options:");
            Console.WriteLine("\t-h\t\t\tShow this dialog");
            Console.WriteLine("\t-g [filename]\t\tGenerate file with random numbers (filename optional)");
            Console.WriteLine("\t-s [filename] [A/d] [new filename] Sort the numbers in ascending or descending order");
            Console.WriteLine("\t-v [filename]\t\tView file content");
            Console.WriteLine("\t-d [filename]\t\tDelete a file");
        }

        static void SortFile(string filename, string newFilename = "", string sortType = "a")
        {
            if (File.Exists(filename))
            {
                string[] numbersAsStrings = File.ReadAllLines(filename);
                int[] numbers = new int[numbersAsStrings.Length];
                for (int i = 0; i < numbers.Length; i++)
                    numbers[i] = int.Parse(numbersAsStrings[i]);
                if (sortType == "a")
                {
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        if (numbers[i] < numbers[i - 1])
                        {
                            for (int k = i; k > 0; k--)
                            {
                                if (numbers[k] < numbers[k - 1])
                                {
                                    int temp = numbers[k - 1];
                                    numbers[k - 1] = numbers[k];
                                    numbers[k] = temp;
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        if (numbers[i] > numbers[i - 1])
                        {
                            for (int k = i; k > 0; k--)
                            {
                                if (numbers[k] > numbers[k - 1])
                                {
                                    int temp = numbers[k - 1];
                                    numbers[k - 1] = numbers[k];
                                    numbers[k] = temp;
                                }
                            }
                        }
                    }
                }
                string input = "y";
                if (File.Exists(newFilename))
                {
                    Console.Write($"{newFilename} exists in the current directory. Do you want to override it? [Y/n]: ");
                    input = Console.ReadLine();
                }
                else
                {
                    if (newFilename == "")
                        newFilename = filename;
                    if (!newFilename.EndsWith(".txt"))
                    {
                        Console.WriteLine("Invalid filename. Only .txt files are allowed");
                        newFilename = "sortedFile.txt";
                    }
                    using (FileStream fs = File.Open(newFilename, FileMode.CreateNew)) { }
                }

                if (input.ToLower() != "n")
                {
                    byte[] newline = Encoding.ASCII.GetBytes(Environment.NewLine);
                    using (FileStream fs = File.Open(newFilename, FileMode.Truncate))
                    {
                        byte[] numberInBytes = new UTF8Encoding(true).GetBytes("");
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numberInBytes = new UTF8Encoding(true).GetBytes(numbers[i].ToString());
                            fs.Write(numberInBytes, 0, numberInBytes.Length);
                            fs.Write(newline, 0, newline.Length);
                        }
                    }
                    Console.WriteLine($"Sorted numbers in {newFilename}.");
                    if (newFilename != filename)
                    {
                        Console.Write($"Delete {filename}? [Y/n]: ");
                        input = Console.ReadLine();
                        if (input.ToLower() != "n")
                        {
                            File.Delete(filename);
                            Console.WriteLine($"{filename} successfuly deleted.");
                        }
                        else
                            Console.WriteLine($"{filename} not deleted.");
                    }
                }
                else
                    Console.WriteLine("Operation canceled");
            }
            else
                Console.WriteLine($"No file named {filename}. Use -g arguement to generate a file or -h for more information.");
        }

        static void ViewFileContent(string filename)
        {
            string line;
            if (File.Exists(filename))
            {
                StreamReader file = new StreamReader(filename);
                while ((line = file.ReadLine()) != null)
                    Console.WriteLine(line);
            }
            else
                Console.WriteLine($"{filename} does not exist in the current directory");
        }
    }
}
