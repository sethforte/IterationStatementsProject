using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a List called "numbers" - DONE!
            List<int> numbers = new List<int>();  // DO NOT ERASE THIS! You will use this in the exercise.

            // Create a variable of type int and name it "num"
            // Initialize the variable with a value of 0
            int num = 0;

            // Create a do-while loop
            do
            {
                num++;
                numbers.Add(num);
            }
            while (num < 100);

            // Create a while loop
            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }

            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");

            // Create a foreach loop
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }

            // End of exercise
        }
    }
}
