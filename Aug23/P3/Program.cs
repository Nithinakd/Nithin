
using System;
class Math
{

   
    public int Add(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

   
    public int Add(int a, int b, int c)
    {
        int sum = a + b + c;
        return sum;
    }


    public static void Main(String[] args)
    {

        
        Math ob = new Math();

        int sum1 = ob.Add(1, 2);
        Console.WriteLine("sum of the two "
                        + "integer value : " + sum1);

    }
}
