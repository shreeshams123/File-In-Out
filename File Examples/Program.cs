using System;
using System.IO;
namespace File_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (File.Create(@"D:\File In-out\sample.txt")) {
                Console.WriteLine("File created successfully");
            }
            using (StreamWriter sw = new StreamWriter(@"D:\File In-out\sample.txt")) { 
            sw.WriteLine("This is a sample file");
            sw.WriteLine("Second line of the file");
        }
            using (StreamReader sr = new StreamReader(@"D:\File In-out\sample.txt"))
            {


                string data = sr.ReadLine();
                while (data != null)
                {
                    Console.WriteLine(data);
                    data = sr.ReadLine();
                }
            }
            File.Copy(@"D:\File In-out\sample.txt", @"D:\File In-out\temp.txt",true);
           


        }
    }
}
