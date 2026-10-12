// A program that outputs when the value of a car will reach a minimum resale value
using System;

namespace csharp_projects
{
    class CarValue
    {
        // A function that prompts a user with a given message
        // It then tries to convert the input into a int. It will undergo type check,
        // presence check, and limit checks
        static int GetInput(string message)
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
                    if (result < 0)
                    { // This implies a failed limit check, must be +ve
                        Console.WriteLine("Please enter a positive number!");
                        continue;
                    } 
                    
                    // This implies all 3 checks have passed
                    return result;
                }
                Console.WriteLine("Please enter an integer!");
            }
        }

        // A procedure that outputs the value of a car each year until the value is so low
        // That it reaches a minimum resale value. Loses 30 % yr1 and 2, then 20% onwards
        static void Depreciate(int year, double price, double minVal)
        {
            int yearsAfter = 0;
            // Keep looping and updating the value while bigger than minimum 
            while (price > minVal)
            {
                Console.WriteLine($"{year + yearsAfter}: £{price:0.00}");
                yearsAfter++;
                if (yearsAfter <= 2) 
                { // This should decrease the value by 30%
                    price *= 0.7;
                }
                else 
                { // > 2 yrs, so decrease only by 20%
                    price *= 0.8;
                }
            }
        }
                

        // Main function of the program
        static void Main(string[] args) 
        {
            int startingYear = GetInput("Enter the year you will sell the car: ");
            int carValue = GetInput("Enter the value of the car: ");
            int minResaleVal = GetInput("Enter the minimum resale value: ");

            // Output the years and the values of the car
            Depreciate(startingYear, carValue, minResaleVal);

        }
    }
}
        
        
                        
    
