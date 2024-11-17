using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace File_Examples
{
    class Class1
    {
        static void Main(string[] args)
        {
            FileInfo f = new FileInfo(@"D:\File In-out\demo.txt");
            using (StreamWriter sw = f.CreateText())
            {
                sw.WriteLine("This is a demo file");
                sw.WriteLine("Second line of demo file");
            }
            using (StreamReader sr = f.OpenText())
            {
                string data=sr.ReadLine();
                while (data != null)
                {
                    Console.WriteLine(data);
                    data = sr.ReadLine();
                }
            }

        }
    }
}
