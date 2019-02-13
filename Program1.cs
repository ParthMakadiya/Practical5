using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace Practical5
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = @"E:\16ce153\file1.txt";
            string file2 = @"E:\16ce153\file2.txt";
            using (StreamReader reader = new StreamReader(file1)) 
            using (StreamWriter writer = new StreamWriter(file2)) 
            writer.Write(reader.ReadToEnd());
        }
    }
}
