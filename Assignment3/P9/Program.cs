using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<float> floatList = new List<float>() { 123.2f, 33.2f, 82f, 55.5f, 190.45f };
            
            foreach (float f in floatList)
            {
                Console.WriteLine(f);
            }
        }
    }
}