using System;

class Program
{
    static void Main()
    {
        // Call the welcome function
        DisplayWelcome();

        // Get user's name
        string userName = PromptUserName();

        // Get user's favorite number
        int favoriteNumber = PromptUserNumber();

        // Square the number
        int squaredNumber = SquareNumber(favoriteNumber);

        // Display the final result
        DisplayResult(userName, squaredNumber);
    }

    // Displays a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Prompts the user for their name and returns it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Prompts the user for their favorite number and returns it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Accepts a number and returns its square
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Displays the user's name and squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
