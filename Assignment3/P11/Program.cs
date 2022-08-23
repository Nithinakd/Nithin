using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            SortedDictionary<int, string> My_sdict =
                new SortedDictionary<int, string>();

          
            My_sdict.Add(002, "HI");
            My_sdict.Add(003, "HELLO");
            My_sdict.Add(001, "HEY");
            
            
            foreach (KeyValuePair<int, string> pair in My_sdict)
            {
                Console.WriteLine(" {0} : {1}",
                                      pair.Key, pair.Value);
            }
        }
    }
}
