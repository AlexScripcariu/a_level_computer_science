// A file that stores any input functions needed (and with validation)
using System;

namespace csharp_projects
{
    public class Input
    {
        //A function that prompts a user with a given message
        // It then tries to convert the input into a int. It will undergo type check,
        // presence check, and limit checks
        public static int GetInput(string message, int? lowerBound=null, int? upperBound=null)
        {
            string? userInput;
            
            // validation loop
            while (true)
            {
                Console.Write(message);
                userInput = Console.ReadLine();
                
                if (string.IsNullOrEmpty(userInput)) 
                { // True if empty string, so fails presence check
                    Console.WriteLine("Please enter a value!");
                    continue;
                }

                if (Int32.TryParse(userInput, out int result))
                { // True if passes the type check
                    if (lowerBound != null && result < lowerBound)
                    { // This implies a failed limit check, must be +ve
                        Console.WriteLine($"Please enter a number bigger than or equal to {lowerBound}!");
                        continue;
                    } 
                    if (upperBound != null && result > upperBound) {
                        Console.WriteLine($"Please enter a number less than or equal to {upperBound}");
                        continue;
                    }
                    // if (result % 5 != 0)
                    // {
                    //     Console.WriteLine("Please enter only multiples of 5!");
                    //     continue;
                    // }
                    // This implies all 3 checks have passed
                    return result;
                }
                Console.WriteLine("Please enter an integer!");
            }
        }

        // This function takes in a message which will be prompted to the user, 
        // Then whatever value is inputted will be returned (string input)
        public static string GetStrInput(string message)
        {
            string? userInput;

            // input validation
            while (true)
            {
                Console.Write(message);
                userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput))
                {   // presence check
                    Console.WriteLine("Please enter a value!");
                    continue;
                } 

                return userInput;
            }
        }
    }
}