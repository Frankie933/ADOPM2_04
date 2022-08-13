using System;

namespace ADOPM2_04_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age = 23;

            var dude1 = new { Name = "Bob", Age = 23 };
            var dude1t = (Name:"Bob", Age:23);

            var dude2 = new { Name = "Bob", Age, Age.ToString().Length };
            var dude3 = new { Name = "Bob", Age = Age, Length = Age.ToString().Length };

            Console.WriteLine(dude1.Name); //Bob
            Console.WriteLine(dude2.Age); // 23
            Console.WriteLine(dude1t.Age); // 23
            Console.WriteLine(dude2.Length); // 2
            Console.WriteLine(dude3.Length); // 2
        }
    }
}
//Exercises:
//1.    Implement above using Tuples instead of anonymous types
