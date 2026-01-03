using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter their percentage
        Console.Write("What is your grade percentage? ");
        // Change type from string to interger
        int percentage = int.Parse(Console.ReadLine());

        
        

        //Identify the grade letter
        string grade = "";

        // Condition checking
        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";    
        }
        else
        {
            grade = "F";
        }

        // Identify the sign
        string sign = "";
        int lastDigit = percentage % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Handling special cases
        //A+ grade not available
        if (grade == "A" && sign == "+")
        {
            sign = "";
        }
         // No F+ or F- grades
        if (grade == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {grade}{sign}");

        if (percentage >= 70)
        {
            Console.WriteLine("You Passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}
