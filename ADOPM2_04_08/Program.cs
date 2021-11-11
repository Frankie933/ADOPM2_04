using System;

namespace ADOPM2_04_08
{
	class Program
	{
		enum Season { Spring, Summer, Fall, Winter };
		static int AverageCelsiusTemperature(Season season, bool daytime, bool abnormal = false) =>
		   (season, daytime) switch
		   {
			   (Season.Spring, true) when abnormal => 30,
			   (Season.Spring, true) => 20,
			   (Season.Spring, false) => 16,
			   (Season.Summer, true) => 27,
			   (Season.Summer, false) => 22,
			   (Season.Fall, true) => 18,
			   (Season.Fall, false) => 12,
			   (Season.Winter, true) => 10,
			   (Season.Winter, false) => -2,
			   _ => throw new Exception("Unexpected combination")
		   };

		static void Main(string[] args)
		{
			Console.WriteLine(AverageCelsiusTemperature(Season.Spring, true)); //20
			Console.WriteLine(AverageCelsiusTemperature(Season.Spring, true, true)); //30
		}
	}

	//Exercises:
	//1.	Create and initialize an array of tuples. Iterate over the array and printout some selected items using tuple pattern in a switch
	//		construct.
	//2.	Create an array of objects and initialize it with various tuples types. Iterate over the array with switch construct using type pattern.
	//		Recognize some specific tuple types and printout result
}
