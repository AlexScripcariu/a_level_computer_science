// // A program that can return the age of a dog (in years) into dog years
// using System;

// namespace csharp_projects
// {
//     class DogAgeCalculator
//     {
        
//         // A procedure that takes in a user input and validates it
//         // It performs a: presence, type, and limit check
//         // If it passes all values, then store the result into a variable
//         static void GetInput(ref double var, string message)
//         {
//             string? userInput;

//             // validation
//             while (true)
//             {
//                 Console.Write(message);
//                 userInput = Console.ReadLine();

//                 // presence check
//                 if (string.IsNullOrEmpty(userInput))
//                 {
//                     Console.WriteLine("Please enter a value!");
//                     continue;
//                 } 
//                 else if (Double.TryParse(userInput, out var)) // type check 
//                 {
//                     if (var <= 0) // limit check, must be positive
//                     {
//                         Console.WriteLine("The years must be positive!");
//                         continue;
//                     }
//                     return; // valid answer
//                 }
//                 Console.WriteLine("Please enter a real number!");
//             }
//         }

//         // A function that takes in the age of a dog
//         // and converts it into dog years and returns the value
//         static double CalculateDogYears(double years)
//         {
//             if (years <= 2)
//             {
//                 return years * 12;
//             } 
//             else
//             {
//                 // formula is 24 + 6 for every year - 2.
//                 return 22 + years * 6;
//             }
//         }

//         // Main function of the program
//         static void Main(string[] args)
//         {
//             double dogAge = 0; // in human years
//             GetInput(ref dogAge, "Enter the dog's age: ");

//             double dogYears = CalculateDogYears(dogAge);
//             Console.WriteLine("{0} years is {1} dog years.", dogAge, dogYears);
//         }
//     }
// }