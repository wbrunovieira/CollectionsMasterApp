﻿using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            int[] numbers = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(numbers);
            //Print the first number of the array

            Console.WriteLine($"\nIndex0:{numbers[0]}\n------------------");
            //Print the last number of the array

            Console.WriteLine($"Last Index: {numbers[^1]}\n--------------");

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Array.Reverse(numbers);

            Console.WriteLine("All Numbers Reversed:");
            NumberPrinter(numbers);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);
            NumberPrinter(numbers);
            Console.WriteLine();
            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            List<int> numberList = new List<int>();


            //Print the capacity of the list to the console
            Console.WriteLine($"List starting capacity: {numberList.Capacity}");


            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numberList);

            //Print the new capacity
            Console.WriteLine($"List capacity after population: {numberList.Capacity} ");

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" on accident and your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int searchNumbers = int.Parse(Console.ReadLine());
            NumberChecker(numberList, searchNumbers);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(numberList);

            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Odds Only!!");
            OddKiller(numberList);
            NumberPrinter(numberList);
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Odds!!");
            numberList.Sort();
            NumberPrinter(numberList);
            
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            var arrayFromList = numberList.ToArray();


            //Clear the list
            numberList.Clear();
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            
        }

        private static void OddKiller(List<int> numberList)
        {
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                int rando = rng.Next(100);
                numbers[i] = rando;
            }

        }        

        private static void ReverseArray(int[] array)
        {
            
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
