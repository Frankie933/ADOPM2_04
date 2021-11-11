using System;

namespace ADOPM2_04_03
{
    class Program
    {
        static void Bar(out int sum, int a = 0, int b = 0, int c = 0, int d = 0)
        {
            sum = a + b + c + d;

        }
        static void Main(string[] args)
        {
            Bar(out int sum, d: 3);
            Console.WriteLine(sum); // 3

            Bar(out _, a: 2, d: 6);
        }
    }
 }
//Exercises
//1.    Declare a method using the parameter modifiers in, out, ref and params and default values. Test changing 
//      the order of the parameters and see what the complier says.
//2.    Call the method using named arguments, and change the order. What happens?

