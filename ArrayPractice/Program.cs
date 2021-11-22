using System;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring a variable to carry the size of the array
            int arraySize;

            //gathering the information to set the Array Size
            Console.WriteLine("Enter the number for the size for your array.");
            arraySize = Convert.ToInt32(Console.ReadLine());

            //initalizing the Array and setting it's size
            int[] someNumbers = new int[arraySize];

            //Adding a space to the printed results
            Console.WriteLine();

            //looping through to add elements to the array
            for (int i = 0; i < someNumbers.Length; i++)
            {
                Console.WriteLine("Please enter an integer");
                someNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }

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
