using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> My_dict1 =
                       new Dictionary<int, string>();

            // Adding key/value pairs 
            // in the Dictionary
            // Using Add() method
            My_dict1.Add(1, "HI");
            My_dict1.Add(2, "HELLO");
            My_dict1.Add(3, "HEY");

            foreach (KeyValuePair<int, string> ele1 in My_dict1)
            {
                Console.WriteLine("{0} : {1}",
                          ele1.Key, ele1.Value);
            }
            Console.WriteLine();

            
            }
        }
    }
