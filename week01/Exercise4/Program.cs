using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        // Please note we could use a do-while loop here instead
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            // Only add the number to the list if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Part 2: Compute the average
        // Notice that we first cast the sum variable to be a float. Otherwise, because
        // both the sum and the count are integers, the computer will do integer division
        // and I will not get a decimal value (even though it puts the result into a float variable).

        // By making one of the variables a float first, the computer knows that it has to
        // do the floating point division, and we get the decimal value that we expect.
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the max
        // There are several ways to do this, such as sorting the list
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}


// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // Create a list to store numbers
//         List<int> numbers = new List<int>();

//         Console.WriteLine("Enter a list of numbers, type 0 when finished.");

//         // Ask the user for numbers until they enter 0
//         while (true)
//         {
//             Console.Write("Enter number: ");
//             int input = int.Parse(Console.ReadLine());

//             if (input == 0)
//             {
//                 break; // stop when 0 is entered
//             }

//             numbers.Add(input);
//         }

//         // ----- Core Requirements -----

//         // Compute the sum
//         int sum = 0;
//         foreach (int number in numbers)
//         {
//             sum += number;
//         }

//         // Compute the average
//         double average = (double)sum / numbers.Count;

//         // Find the largest number
//         int largest = numbers[0];
//         foreach (int number in numbers)
//         {
//             if (number > largest)
//             {
//                 largest = number;
//             }
//         }

//         // Display core results
//         Console.WriteLine($"The sum is: {sum}");
//         Console.WriteLine($"The average is: {average}");
//         Console.WriteLine($"The largest number is: {largest}");

//         // ----- Stretch Challenges -----

//         // Find the smallest positive number
//         int smallestPositive = int.MaxValue;
//         bool foundPositive = false;

//         foreach (int number in numbers)
//         {
//             if (number > 0 && number < smallestPositive)
//             {
//                 smallestPositive = number;
//                 foundPositive = true;
//             }
//         }

//         if (foundPositive)
//         {
//             Console.WriteLine($"The smallest positive number is: {smallestPositive}");
//         }

//         // Sort the list
//         numbers.Sort();

//         // Display the sorted list
//         Console.WriteLine("The sorted list is:");
//         foreach (int number in numbers)
//         {
//             Console.WriteLine(number);
//         }
//     }
// }
