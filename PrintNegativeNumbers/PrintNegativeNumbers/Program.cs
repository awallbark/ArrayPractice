using System;

namespace PrintNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize;

            Console.WriteLine("Enter the size of your array");
            arraySize = Convert.ToInt32(Console.ReadLine());
            int[] negativeArray = new int[arraySize];

            Console.WriteLine("Please enter positive and negative integers");

            for (int i = 0; i < negativeArray.Length; i++)
            {
                negativeArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The negative elements of the array are as follows.....");

            for (int i = 0; i < negativeArray.Length; i++)
            {
                int j = negativeArray[i];

                if (j < 0)
                {
                    Console.WriteLine(negativeArray[i]);
                }
            }
      
        }
    }
}
