using System;

namespace ADOPM2_04_02
{
    class Program
    {
        static int Sum(params int[] ints)
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
                sum += ints[i];
            return sum;
        }
        static void Main(string[] args)
        {
            int total = Sum(1, 2, 3, 4);
            Console.WriteLine(total);  // 10

            // The call to Sum above is equivalent to:
            int total2 = Sum(new int[] { 1, 2, 3, 4 });
            Console.WriteLine(total2); // 10
        }
    }
}
//Exercises
//1.    Declare a method that takes params parameter of your own class type and prints out the type.
//2.    Create a single dimension array of the type and call the method both with comma separated list
//      and as an array

