using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "HELLO WORLD";

      
            int index1 = str.IndexOf('W');

            Console.WriteLine("The Index Value of character 'W' is " + index1);

          
            int index2 = str.IndexOf('C');

       
            Console.WriteLine("The Index Value of character 'C' is " + index2);
        }
    }
}
