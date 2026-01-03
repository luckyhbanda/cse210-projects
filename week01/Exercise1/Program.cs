// Referencing the system namespace
using System;

// Our shell for all the functions
class Program
{
    // Main Function which can recieve parameters
    static void Main(string[] args)
    {
        // Prompt the user to enter their first name.
        Console.WriteLine("What is your first name? ");
        string first_name = Console.ReadLine();

        // Prompt the user to enter their last name.
        Console.WriteLine("What is your last name? ");
        string last_name = Console.ReadLine();

        // Prints out the interporated output.
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}
