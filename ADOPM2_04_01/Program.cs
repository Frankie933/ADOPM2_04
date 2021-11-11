using System;

namespace ADOPM2_04_01
{
    class Program
    {
        static void PassingValByValRef(int p, ref int rp)
        {
            p += 1;
            rp += 1;
            Console.WriteLine(p + " " + rp); // 3 3
        }

        static void PassingRefByVal(int[] pArray, ref int[] rpArray)
        {
            pArray[0] = 888;  // This change affects the original element.
            pArray = new int[5] { -3, -1, -2, -3, -4 };   // This change is local.
            System.Console.WriteLine(pArray[0]); //-3

            // Both of the following changes will affect the original variables:
            rpArray[0] = 888;
            rpArray = new int[5] { -3, -1, -2, -3, -4 };
        }

        static void Main(string[] args)
        {
            (int p, int rp) = (2, 2);

            PassingValByValRef(p, ref rp);
            Console.WriteLine(p + " " + rp); //2 3

            int[] pArray = { 1, 4, 5 };
            int[] rpArray = { 1, 4, 5 };

            System.Console.WriteLine(pArray[0] + " " + rpArray[0]); // 1 1
            PassingRefByVal(pArray, ref rpArray);
            System.Console.WriteLine(pArray[0] + " " + rpArray[0]); // 888 -3

        }
    }
}
//Exercises
//1.    Discuss this in the group so you truly understand what happens and why.
//2.    Play around with PassingValByValRef and PassingValByValRef using your own struct and classes as parameters.
//      Modify the passed object in the method to test if original objet is changed. Explain why

