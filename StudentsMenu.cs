using System;
using System.IO;

namespace StudentsMenu
{
    class Student
    {
        public string Name;
        public string FacultyNumber;
        public decimal[] Marks;
    }
    class Program
    {
        static int ReadInt(string prompt)
        {
            bool valid;
            int input;

            do
            {
                Console.Write(prompt);
                valid = int.TryParse(Console.ReadLine(), out input);
                if (!valid)
                    Console.WriteLine("Please enter an integer.");
            }
            while (!valid);
            return input;
        }
        static string ReadString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        static decimal ReadDecimal(string prompt)
        {
            bool valid;
            decimal input;

            do
            {
                Console.Write(prompt);
                valid = decimal.TryParse(Console.ReadLine(), out input);
                if (!valid)
                    Console.WriteLine("Please enter a decmal number.");
            }
            while (!valid);
            return input;
        }
        static void Main(string[] args)
        {
            Student[] students = new Student[100];
            int count = 0;
            int choice;
            do
            {
                Console.WriteLine("\n1.Add student");
                Console.WriteLine("2.Average grade");
                Console.WriteLine("3.Write to file");
                Console.WriteLine("4.Read from file");
                Console.WriteLine("5.Highest average success");
                Console.WriteLine("0.Exit");

                choice = ReadInt("Choose a command: ");

                switch (choice)
                {
                    case 1:
                        Student s = new Student();
                        s.Name = ReadString("Name: ");
                        s.FacultyNumber = ReadString("Faculty number: ");

                        int marksCount = ReadInt("Number of grades: ");
                        s.Marks = new decimal[marksCount];
                        for (int i = 0; i < marksCount; ++i)
                            s.Marks[i] = ReadDecimal("Оценка " + (i + 1) + ": ");

                        students[count++] = s;
                        break;
                    case 2:
                        for (int i = 0; i < count; ++i)
                        {
                            decimal avg = 0;
                            foreach (var mark in students[i].Marks)
                                avg += mark;
                            if (students[i].Marks.Length != 0)
                                avg /= students[i].Marks.Length;
                            Console.WriteLine("Faculty number: {0}\tName: {1}\tAverage grade: {2}",
                                students[i].FacultyNumber,
                                students[i].Name, avg);
                        }
                        break;
                    case 3:
                        string[] fileData = new string[count * 3];
                        for (int i = 0; i < count; ++i)
                        {
                            fileData[3 * i + 0] = students[i].Name;
                            fileData[3 * i + 1] = students[i].FacultyNumber;
                            fileData[3 * i + 2] = "";
                            foreach (var mark in students[i].Marks)
                                fileData[3 * i + 2] += mark + " ";
                        }

                        File.WriteAllLines("data.txt", fileData);
                        Console.WriteLine("File saved successfuly.");
                        break;
                    case 4:
                        count = 0;
                        if (!File.Exists("data.txt"))
                        {
                            Console.WriteLine("The file does not exist.");
                            break;
                        }

                        string[] stData = File.ReadAllLines("data.txt");
                        for (int i = 0; i < stData.Length; i += 3)
                        {
                            var st = new Student();
                            st.Name = stData[i];
                            st.FacultyNumber = stData[i + 1];
                            var textMarks = stData[i + 2].Split();
                            st.Marks = new decimal[textMarks.Length - 1];
                            for (int k = 0; k < st.Marks.Length; ++k)
                                st.Marks[k] = decimal.Parse(textMarks[k]);
                            students[count++] = st;
                        }
                        Console.WriteLine("File read successfuly.");
                        break;
                    case 5:
                        decimal maxAverage = decimal.MinValue;
                        string maxAverageName = default(string);
                        string maxAverageFacultyNumber = default(string);
                        for (int i = 0; i < count; ++i)
                        {
                            decimal avg = 0;
                            foreach (var mark in students[i].Marks)
                            {
                                avg += mark;
                            }
                            if (students[i].Marks.Length != 0)
                            {
                                avg /= students[i].Marks.Length;
                            }
                            if (avg >= maxAverage)
                            {
                                maxAverage = avg;
                                maxAverageFacultyNumber = students[i].FacultyNumber;
                                maxAverageName = students[i].Name;
                            }

                        }
                        Console.WriteLine("Faculty number: {0}\tName: {1}\tAverage grade: {2}",
                            maxAverageFacultyNumber,
                            maxAverageName,
                            maxAverage);
                        break;
                }

            } while (choice != 0);
        }
    }
}
