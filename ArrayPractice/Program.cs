using System;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practice problem from https://www.csharp-console-examples.com/arrays/c-array-exercises/

            //declaring a variable to carry the size of the array
            int arraySize;

            //gathering the information to set the Array Size
            Console.WriteLine("Enter the number for the size for your array:");
            arraySize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The size of the array is {0}", arraySize);

            //initalizing the Array and setting it's size
            int[] someNumbers = new int[arraySize];

            //Adding a space to the printed results
            Console.WriteLine();

            Console.WriteLine("Enter {0} elements into the array", arraySize);

            int i = 0;
            do
            {
                someNumbers[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            } while (i < someNumbers.Length);

            //looping through to add elements to the array
            //for (int i = 0; i < someNumbers.Length; i++)
            //{
            //    Console.WriteLine("Please enter an integer");
            //    someNumbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Adding a space to the printed results
            Console.WriteLine();

            //printing all elements of the array
            foreach (var integer in someNumbers)
            {
                Console.WriteLine(integer);
            }
        }
    }
}
