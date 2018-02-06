using System;
using System.IO;
using System.Text;

namespace FileEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileBytes = new BytesList();
            try
            {
                using (var f = File.Open("storage.txt", FileMode.Open))
                {
                    int read;
                    do
                    {
                        var buffer = new byte[10];
                        read = f.Read(buffer, 0, buffer.Length);
                        fileBytes.AddRange(buffer, read);
                    }
                    while (read > 0);
                    var s = Encoding.UTF8.GetString(fileBytes.ToArray());
                    Console.Write(s);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found: " + e);
            }
            Console.ReadLine();
        }
    }
}