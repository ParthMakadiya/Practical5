using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace filepractical2
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = @"E:\16ce153\file1.txt";
            string file2 = @"E:\16ce153\file3.txt";
            using (StreamReader reader= new StreamReader(file1))
            using (StreamWriter writer = new StreamWriter(file2))
            {
                string temp = null;
                while ((temp = reader.ReadLine()) != null)
                    writer.WriteLine(temp);
            }

        }
    }
}
