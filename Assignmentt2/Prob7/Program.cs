using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double  phy, che, ms, total;
            double per;
            string  div;




            Console.Write("Input  the marks of Physics : ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of  Chemistry : ");
            che = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of Maths : ");
            ms = Convert.ToInt32(Console.ReadLine());

            total = phy + che + ms;
            per = total / 3.0;
            if (per >= 60)
                div = "First";
            else
            if (per < 60 && per >= 45)
                div = "Second";
            else
                if (per < 45 && per >= 35)
                div = "Pass";
            else
                div = "Fail";
            Console.Write("Total Marks = {0}\nPercentage = {1}\nResult = {2}\n", total, per, div);
        }
    }
}
