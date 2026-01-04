using System;

class Program
{
    static void Main(string[] args)
    {
        // For Parts 1 and 2, where the user specified the number...
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        
        // For Part 3, where we use a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // We could also use a do-while loop here...
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}


// using System;

// class Program
// {
//     static void Main()
//     {
//         string playAgain = "yes";

//         // Loop to allow playing the game multiple times
//         while (playAgain.ToLower() == "yes")
//         {
//             // Create a random number generator
//             Random randomGenerator = new Random();
//             int magicNumber = randomGenerator.Next(1, 101); // 1 to 100

//             int guess = -1;
//             int guessCount = 0;

//             Console.WriteLine("I have chosen a magic number between 1 and 100.");

//             // Loop until the user guesses correctly
//             while (guess != magicNumber)
//             {
//                 Console.Write("What is your guess? ");
//                 guess = int.Parse(Console.ReadLine());
//                 guessCount++;

//                 if (guess < magicNumber)
//                 {
//                     Console.WriteLine("Higher");
//                 }
//                 else if (guess > magicNumber)
//                 {
//                     Console.WriteLine("Lower");
//                 }
//                 else
//                 {
//                     Console.WriteLine("You guessed it!");
//                 }
//             }

//             // Display number of guesses
//             Console.WriteLine($"It took you {guessCount} guesses.");

//             // Ask if the user wants to play again
//             Console.Write("Do you want to play again? (yes/no): ");
//             playAgain = Console.ReadLine();
//             Console.WriteLine();
//         }

//         Console.WriteLine("Thanks for playing!");
//     }
// }
