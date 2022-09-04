using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\Admin\Desktop\MainProject\students.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filepath).ToList();
            Console.ReadLine();
        }
    }
}
