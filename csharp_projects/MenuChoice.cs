// A program that teaches how to handle user inputs
using System;

namespace csharp_projects
{
    class MenuChoice
    {
        // Function to return an input
        static string GetInput()
        {
            Console.WriteLine("N - Move North");
            Console.WriteLine("E - Move East");
            Console.WriteLine("S - Move South");
            Console.WriteLine("W - Move West");
            Console.WriteLine("[Enter] stop");
            Console.WriteLine("Enter an option number: ");
            string choice = Console.ReadLine();

            return choice;
        }

        // Main function of the program
        static void Main(string[] args) 
        {
            string choice = "Hello";
            while (choice != "") 
            {
                choice = GetInput();
                Console.WriteLine("You chose option {0}.", choice);
            }
            
        }
    }
}
