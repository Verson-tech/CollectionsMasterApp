using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] array = new int[50];
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(array);

            //TODO: Print the first number of the array
            Console.WriteLine(array[0]);
            //TODO: Print the last number of the array            
            Console.WriteLine(array[^1]);
            // ||
            //Console.WriteLine(array[array.Length - 1]);
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(array);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");



            Console.WriteLine("---------REVERSE CUSTOM------------");

            
            //Array.Reverse(array);
            //NumberPrinter(array);
            ReverseArray(array);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(array);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(array);
            NumberPrinter(array);


            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var numberList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(numberList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numberList);
            

            //TODO: Print the new capacity
            Console.WriteLine(numberList.Capacity);
        
            

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int userInput = Int32.Parse(Console.ReadLine());
            NumberChecker(numberList, userInput);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numberList);
            NumberPrinter(numberList);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numberList.Sort();
            NumberPrinter(numberList);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var listToArray = numberList.ToArray();
            

            //TODO: Clear the list
            numberList.Clear();
            NumberPrinter(numberList);


            #endregion
        }
        private static void ThreeKiller(int[] array)
        //private static void ThreeKiller(int[] numbers)
        {
              for (int i = 0; i<array.Length; i++)               
            {
                if ((array[i] % 3) == 0)
                {
                    Console.WriteLine(array[i]);
                }
}
        }

        private static void OddKiller(List<int> numberList)
        {
            foreach(var item in numberList.ToList())
            {
                if (item % 2 != 0)
                {
                    numberList.Remove(item);
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int userInput)
        {
            bool wasFound = false;

            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] == userInput)
                {
                    Console.WriteLine("Found it!");
                    wasFound = true;
                    break;
                }
            }
            //foreach (var number in numberList)
            //{
            //    if (number == searchNumber)
            //    {
            //        Console.WriteLine("Found it!");
            //        wasFound = true;
            //        break;
            //    }
            //}

            if (!wasFound)
            {
                Console.WriteLine("Couldn't find it!");
            }

        }

        private static void Populater(List<int> numberList)
        {
            Random randNum = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(randNum.Next(0,51));
            }
        }

        private static void Populater(int[] numbers)
        {

            int min = 0;
            int max = 51;
            Random randNum = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randNum.Next(min, max);
            }
        }

        private static void ReverseArray(int[] array)
            //private static int(int[] array)
        {
            Array.Reverse(array);
            NumberPrinter(array);
            //var arrayReversed = new int[array.Length];
            //int j = 0;
            //for (int i = array.Lenght -1; i>= 0; i--)
            //{
            //arrayReversed[j] = array[i];
            //j++;
            //}
            //array = arrayReversed;
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
