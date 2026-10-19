// A program that allows a user to guess a number and sees if it matches
// A dice roll
using System;

namespace csharp_projects
{
    class ValidOption
    {
        // Function to return an input as an integer
        static int GetInput()
        {
            Console.WriteLine("What do you think the dice roll will be? ");

            string choice = " ";
            bool validChoice = false;

            while (!validChoice) 
            {
                Console.WriteLine("Enter a guess: ");
                choice = Console.ReadLine();

                if (char.IsNumber(Convert.ToChar(choice)) == true) 
                {
                    validChoice = true;
                }

                if (!validChoice)
                {
                    Console.WriteLine("Invalid choice.");
                }
            }

            return Convert.ToInt32(choice);
        }

        // Main function of the program
        static void Main(string[] args) 
        {
            Random dice = new Random();

            int roll = dice.Next(1, 7);
            int choice = GetInput();

            Console.WriteLine("The roll was {0}, you guessed {1}", roll, choice);
        }
    }
}
