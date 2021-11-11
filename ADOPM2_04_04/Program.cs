using System;

namespace ADOPM2_04_04
{
    class Program
    {
        // Tuples works perfect with a method returning multiple values.
        // Here with simple Expression bodied method 
        static (string, string, decimal) GetFavoriteBook1() =>
            ("The Count of Monte Cristo", "Alexandre Dumas", 75.25M);

        static (string Title, string Author, decimal Price) GetFavoriteBook2() =>
            ("The Count of Monte Cristo", "Alexandre Dumas", 75.25M);

        static void Main(string[] args)
        {
            // Four ways to declare tuples
            // 1. Types inferred - Elements accessed using .Item
            var Book1 = ("Robinson Crusoe", "Daniel Defoe", 150.50M);  
            Console.WriteLine(Book1.Item1);        // Robinson Crusoe

            // 3. Types inferred, elements named - accessed by name
            var Book2 = (Title: "Robinson Crusoe", Author: "Daniel Defoe", Price: 150.50M);
            Console.WriteLine(Book2.Title);         // Robinson Crusoe

            // 2. Types explicit, - Elements accessed using .Item
            (string, string, decimal) Book3 = ("Robinson Crusoe", "Daniel Defoe", 150.50M);
            Console.WriteLine(Book3.Item1);        // Robinson Crusoe

            // 4. Types explicit, element names inferred - access by name
            (string Title, string Author, decimal Price) Book4 = ("Robinson Crusoe", "Daniel Defoe", 150.50M);
            Console.WriteLine(Book4.Title);         // Robinson Crusoe

            // All four declarations are equal
            Console.WriteLine(Book1 == Book2); // True
            Console.WriteLine(Book2 == Book3); // True
            Console.WriteLine(Book3 == Book4); // True

            // Set by Method returning tuples
            var FavoriteBook1 = GetFavoriteBook1();
            Console.WriteLine(FavoriteBook1.Item1); // The Count of Monte Cristo

            var FavoriteBook2 = GetFavoriteBook2();
            Console.WriteLine(FavoriteBook2.Title); // The Count of Monte Cristo

            // Tuples are type compatible, not considerning element names
            Book1 = GetFavoriteBook2();
            Console.WriteLine(Book1.Item1);         // The Count of Monte Cristo
            Book4 = GetFavoriteBook1();
            Console.WriteLine(Book4.Title);         // The Count of Monte Cristo

            // Create a tuple with different type order
            var WrongBook1 = (150.50M, "Robinson Crusoe", "Daniel Defoe");
            //Book1 = WrongBook1;                     // Compiler Error

            // Tuples are easily deconstructed and members discarded
            (string MyTitle, _, decimal MyPrice) = GetFavoriteBook1();
            Console.WriteLine(MyTitle);
            Console.WriteLine(MyPrice);
        }
    }
}
//Exercises:
//1.    Declare two variables of type tuple (decimal, double, int) and initialize to some values of your choise.
//2.    Declare two variable of type tuple (string, bool) and initialize to some values of your choise.
//2.    In project DeckOfCards, in Main, Declare two tuples variable tupleCard1 and tupleCard2 of type (PlayingCardColor, PlayingCardValue)
