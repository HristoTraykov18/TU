using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using d1;

// Sorting file permission check
// Add edit file option
// Delete only .txt files created by the program
// System.IO.FileNotFoundException not handled for some reason

namespace p1
{
    class p1
    {
        static void Main(string[] args)
        {
            try
            {
                if (args[0].ToLower() == "-h" || args[0] == null)
                {
                    DynamicLib.ShowHelp();
                }
                else if (args[0].ToLower() == "-g")
                {
                    try { DynamicLib.GenerateFile(args[1]); }
                    catch (IndexOutOfRangeException) { DynamicLib.GenerateFile(); }
                }
                else if (args[0].ToLower() == "-s")
                {
                    try { DynamicLib.SortFile(args[1], args[2], args[3]); }
                    catch (IndexOutOfRangeException) { DynamicLib.SortFile(args[1], args[2], "a"); }
                }
                else if (args[0].ToLower() == "-v")
                    DynamicLib.ViewFileContent(args[1]);
                else if (args[0].ToLower() == "-d")
                    DynamicLib.DeleteFile(args[1]);
                else
                    Console.WriteLine($"Invalid arguement \nUse -h for help");
            }
            catch (System.IO.FileNotFoundException) { Console.WriteLine("Error: d1.dll is not in the current folder"); }
            catch (IndexOutOfRangeException) { DynamicLib.ShowHelp(); }
        }
    }
}
