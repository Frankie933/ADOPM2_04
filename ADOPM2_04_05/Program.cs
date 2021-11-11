using System;

namespace ADOPM2_04_05
{
    class Program
    {
        public struct Point
        {
            public long X, Y;
        }
        public struct Rectangle
        {
            public Point BottomLeft, TopRight;
       
            public long Width() { return Math.Abs(TopRight.X - BottomLeft.X); }
            public long Height() => Math.Abs(TopRight.Y - BottomLeft.Y);

            public bool Equals1 (Rectangle r1)
            {
                // traditional comparison member by member in an if statement
                if (r1.BottomLeft.X == BottomLeft.X && r1.BottomLeft.Y == BottomLeft.Y &&
                    r1.TopRight.X == TopRight.X && r1.TopRight.Y == TopRight.Y)
                    return true;

                return false;
            }

            public bool Equals2(Rectangle r1)
            {
                // traditional comparison member by member, returning expression result
                return (r1.BottomLeft.X == BottomLeft.X && r1.BottomLeft.Y == BottomLeft.Y &&
                    r1.TopRight.X == TopRight.X && r1.TopRight.Y == TopRight.Y);
            }

            public bool Equals3(Rectangle r1)
            {
                // Using the simple tuple construct to compare
                return ((r1.BottomLeft.X, r1.BottomLeft.Y, r1.TopRight.X, r1.TopRight.Y) ==
                        (BottomLeft.X, BottomLeft.Y, TopRight.X, TopRight.Y));
            }

            // Instance constructor
            public Rectangle(long x, long y, long width = 10, long height = 100)
            {
                BottomLeft = new Point { X = x, Y = y };
                TopRight = new Point { X = x + width, Y = y + height };
            }
        }
        static void Main(string[] args)
        {
            var r1 = new Rectangle(0, 0);
            var r2 = new Rectangle(0, 0);
            var r3 = new Rectangle(10, 10);

            Console.WriteLine(r1.Equals3(r2));
            Console.WriteLine(r1.Equals3(r3));
        }
    }
}
//Exercises:
//1.    With the tuple variables you created in Exercise BOOP_04_03.1 to 3, write code to test if the pairs are equal.
//      If so Print "Tuple cards are equal" otherwise Print "Tuple cards are not equal"
//2.    Challange: In project DeckOfCards, declare a static method called AreEqual with return type bool, that takes two parameters
//      of type PlayingCard - card1 and card2. 
//      Write code in AreEqual to test if the two cards are equal. If so return true otherwise false.
//      Use Expression method syntax and tuple when comparing if you can - it can be don in one line of code.
//3.    Create two cards, singleCard1 and singleCard2 to test AreEqual. if equal print "Single cards are equal" otherwise
//      "Single cards are not equal"
