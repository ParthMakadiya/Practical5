using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace filepractical3
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Directories = Directory.GetDirectories(@"E:\16ce153");
            foreach (string dir in Directories)
                Console.WriteLine(dir);
            Console.WriteLine("files are :");
            String[] files = Directory.GetFiles(@"E:\16ce153");
            foreach (string file in files)
                Console.WriteLine(file);
                 Console.ReadKey();

        }
    }
}
