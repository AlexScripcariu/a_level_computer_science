// A program that can calculate the LCM of any two numbers
// This is done by a linear search through all numbers from 1,
// Once a number is divisible by both the numbers, it is returned
using System;

namespace csharp_project 
{
    class LCMProgram 
    {
        // Subroutine that calculates the LCM of two numbers, a and b,
        // Via linear search
        static int LCM(int number1, int number2) 
        {
            int counter = 1;

            while ((counter % number1 != 0) || (counter % number2 != 0)) 
            {
                counter++;
            }

            return counter;
        }

        // Main function of the program
        static void Main(string[] args) 
        {
            int number1 = 20;
            int number2 = 7;
            int result = LCM(number1, number2);
            // Output to console
            Console.WriteLine($"The LCM of {number1} and {number2} is {result}");
        }
    }
}
        
