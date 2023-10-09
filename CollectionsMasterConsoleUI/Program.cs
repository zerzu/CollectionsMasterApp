using System;
using System.Collections.Generic;
using System.Collections.Immutable;

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
            //TODO: Create an integer Array of size 50 DONE!

            var numbers = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50   DONE!
            
            Populater(numbers);
            
            //TODO: Print the first number of the array DONE!

            Console.WriteLine(numbers[0]);

            //TODO: Print the last number of the array  DONE!          

            Console.WriteLine(numbers[49]);

            Console.WriteLine("All Numbers Original");

            // uncomment this method to print out your numbers from arrays or lists DONE!

            NumberPrinter(numbers);

            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a built in method => Hint: Array._____();           DONE!
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)    DONE!
            */

            Console.WriteLine("All Numbers Reversed:");

            Array.Reverse(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
           // DONE!
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(numbers);
            NumberPrinter(numbers);


            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List

            var numberList = new List<int>();

            //TODO: Print the capacity of the list to the console

            Console.WriteLine($"{numberList.Capacity}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this  DONE!            

            Populater(numberList);
           

            //TODO: Print the new capacity  DONE!

            Console.WriteLine($"{numberList.Capacity}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!  DONE!
            
            bool isNumber;
            int numberParse;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isNumber = int.TryParse(Console.ReadLine(), out numberParse);

            }while (!isNumber);  

            NumberChecker(numberList, numberParse);


            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            
            //UNCOMMENT this method to print out your numbers from arrays or lists
            
            NumberPrinter(numberList);
            
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results   DONE!
            
            Console.WriteLine("Evens Only!!");
            
            OddKiller(numberList);
            
            NumberPrinter(numberList);
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results    DONE!

            Console.WriteLine("Sorted Evens!!");

            numberList.Sort();

            NumberPrinter(numberList);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable DONE!

            var listConverter = numberList.ToArray();
            
            //TODO: Clear the list  DONE!

            numberList.Clear();

        }
            #endregion
        

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count - 1; i++)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList[i] = 0;
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"I have found your number, {searchNumber} at position {numberList.IndexOf(searchNumber)}");
            }

            else
            {
                Console.WriteLine($"I am sorry {searchNumber} does not exist in the list.");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 50));
            }


        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = (rng.Next(0, 50));
                }
            

        }        

        private static void ReverseArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                var temp1 = array[i];
                var temp2 = array[array.Length - (i + 1)];
                array[i] = temp2;
                array[array.Length - (i + 1)] = temp1;

            }
            
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
