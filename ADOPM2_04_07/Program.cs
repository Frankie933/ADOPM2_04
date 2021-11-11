using System;

namespace ADOPM2_04_07
{
    class Program
    {
        public class Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
        }

        //Type pattern combined with Property pattern
        static string VariousPatternMatching(object obj) => obj switch
        {
            //Constant Pattern
            true => "True",
            5 => "Five",
            5.3F => "Five comma three",

            //Relational Pattern and Pattern Combination
            < 10 and > 2 => "Less than 10 and larger than 2",

            //Type Pattern
            float => "type of float",

            //Type pattern with declaration pattern using when
            int i when i < 3 => "integer less than 3",

            //Type Pattern, Property Pattern and Relational Pattern
            string { Length: > 4 } => "string with length > 4",

            //Type pattern with declaration pattern using when
            Shape { Width: 50 } s when s.Height > 100 => "Shape with Width = 50 and Height > 100",

            //Type Pattern and Property Pattern
            Uri { Scheme: "https", Port: 443 } => "Uri with Scheme=https and Port=443",

            //Type Pattern, Property Pattern, Relatinal Pattern, Var Pattern
            Uri { Scheme: "http", Port: < 80, Host: var host } when host.Length < 1000 => "host.Lenght < 1000",

            //Discard Pattern
            _ => "discarded"


        };

        //Classic Relational Pattern and Constant Pattern
        string GetWeightCategory(decimal bmi) => bmi switch
        {
            < 18.5m => "underweight",
            < 25m => "normal",
            < 30m => "overweight",
            35 => "BMI exactly 50",
            _ => "obese"
        };

        //Var Pattern    
        bool IsJanetOrJohn(string name) =>
            name.ToUpper() is var upper && (upper == "JANET" || upper == "JOHN");

        //Pattern Combinators
        bool IsVowel(char c) => c is 'a' or 'e' or 'i' or 'o' or 'u';

        bool Between1And9(int n) => n is >= 1 and <= 9;

        bool IsLetter(char c) => c is >= 'a' and <= 'z'
                                    or >= 'A' and <= 'Z';

        static void Main(string[] args)
        {
            //Relational Pattern with object type
            object obj = 2m;                  // decimal
            Console.WriteLine(obj is < 3m);  // True
            Console.WriteLine(obj is < 3);   // False

            //Not pattern
            Console.WriteLine(obj is not string);
            Console.WriteLine();

            //Various Pattern Matching
            //Test Constant and Relational Pattern
            Console.WriteLine(VariousPatternMatching(true));   // True
            Console.WriteLine(VariousPatternMatching(5));      // Five
            Console.WriteLine(VariousPatternMatching(5.3F));   // Five comma three
            Console.WriteLine(VariousPatternMatching(7));      // Less than 10 and larger than 2

            //Test Type Pattern and Declaration Pattern
            Console.WriteLine(VariousPatternMatching(11.3F));  // Type of float
            Console.WriteLine(VariousPatternMatching(1));      // integer less than 3

            //Test Type Pattern, Property Pattern and Relational Pattern
            Console.WriteLine(VariousPatternMatching("The quick brown fox")); // string with length > 4

            //Test Type pattern with declaration pattern using when
            Console.WriteLine(VariousPatternMatching(
                new Shape { Width = 50, Height = 200 }));      // Shape with Width = 50 and Height > 100

            //Test Type Pattern and Property Pattern
            Console.WriteLine(VariousPatternMatching(
                new Uri("https://localhost:443")));            // Uri with Scheme = https and Port = 443

            //Test Type Pattern, Property Pattern, Relatinal Pattern, Var Pattern
            Console.WriteLine(VariousPatternMatching(
                new Uri("http://localhost:60")));             // host.Lenght < 1000

            //Test Discard Pattern
            Console.WriteLine(VariousPatternMatching(100L));  // discarded
        }
    }

    //Exercises:
    //1.    Shift the order of the patterns in VariousPatternMatching(). Explain what happens.
    //2.    Add some patterns to VariousPatternMatching() and test them
    //3.    Write Code to test the  patterns under //Classic Relational Pattern and Constant Pattern
    //4.    Write your own switch expression using some simple patterns
}
