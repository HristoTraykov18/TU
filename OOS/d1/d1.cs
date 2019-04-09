using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace d1
{
    public class DynamicLib
    {
        public static void DeleteFile(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
                Console.WriteLine($"{filename} successfuly deleted.");
            }
            else
                Console.WriteLine($"{filename} does not exist.");
        }

        public static void GenerateFile(string filename = "generatedFile.txt")
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

        public static void ShowHelp()
        {
            Console.WriteLine("p1.exe options:");
            Console.WriteLine("\t-h\t\t\tShow this dialog");
            Console.WriteLine("\t-g [filename]\t\tGenerate file with random numbers (filename optional)");
            Console.WriteLine("\t-s [filename] [new filename] [A/d] Sort the numbers in ascending or descending order");
            Console.WriteLine("\t-v [filename]\t\tView file content");
            Console.WriteLine("\t-d [filename]\t\tDelete a file");
        }

        public static void SortFile(string filename, string newFilename = "", string sortType = "a")
        {
            if (File.Exists(filename))
            {
                string[] numbersAsStrings = File.ReadAllLines(filename);
                int[] numbers = new int[numbersAsStrings.Length];
                for (int i = 0; i < numbers.Length; i++)
                    numbers[i] = int.Parse(numbersAsStrings[i]);
                string orderType = "";
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
                    orderType = "ascending";
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
                    orderType = "descending";
                }
                string input = "y";
                if (File.Exists(newFilename))
                {
                    Console.Write($"{newFilename} exists in the current directory. Do you want to override it? [Y/n]: ");
                    input = Console.ReadLine();
                }
                else
                {
                    if (newFilename == "" || !newFilename.EndsWith(".txt"))
                        newFilename = filename;
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
                    Console.WriteLine($"Sorted numbers in {newFilename} in {orderType} order.");
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

        public static void ViewFileContent(string filename)
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
