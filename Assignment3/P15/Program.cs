using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15
{
    public class Program
    {
     public static int findMininimumIndex(int[] arr)
        {
            int minIndex = -1;

            ISet<int> set = new HashSet<int>();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (set.Contains(arr[i]))
                {
                    minIndex = i;
                }
                else
                {
                    set.Add(arr[i]);
                }
            }

            return minIndex;
        }

        public static void Main(string[] args)
        {
            int[] arr = new int[] {0,1,5,3,4,3,5,6 };

            Console.Write(findMininimumIndex(arr));
        }
    }
}
