// // A program that takes 2 numbers: a, b, and returns True iff b | a
// // if b == 0 or a % b != 0, then return False
// // ASSUMPTION!: numbers are both integers.
// using System;

// namespace csharp_projects
// {
//     class DivisibilityChecker
//     {
//         // A procedure that asks the user for input,
//         // and stores the given value into the passed in variable
//         // this only happens if it passes validation checks
//         static void GetInput(ref int var, string message)
//         {
//             string? userInput;
            
//             // Validation checks
//             while (true)
//             {
//                 Console.Write(message);
//                 userInput = Console.ReadLine();
                
//                 // presence check
//                 if (string.IsNullOrEmpty(userInput))
//                 {
//                     Console.WriteLine("The input was empty!");
//                 } 

//                 // type check
//                 if (Int32.TryParse(userInput, out var))
//                 {
//                     return; // this implies it has passed both checks
//                 }

//                 Console.WriteLine("Please enter an integer!");
//             }
//         }

//         // A function that determines if b divides a. Returns true/false
//         // Potential issues: dividing by 0, negative modulus
//         static bool IsDivisible(int dividend, int divisor)
//         {
//             if (divisor == 0)
//             {
//                 return false; // This is because we cannot divide by 0.
//             }

//             // Issues can arise with negative modulus. 
//             // How this can be fixed should be explain somewhere on the slide.
//             if ((dividend - (dividend / divisor) * divisor) % divisor == 0)
//             {
//                 return true;
//             }
//             return false; // this would imply b does not divide a
//         }

//         // Main function of the program
//         static void Main(string[] args)
//         {
//             // dividend / divisor = quotient.
//             int dividend = 0;
//             int divisor = 0;
//             GetInput(ref dividend, "Please enter the dividend: ");
//             GetInput(ref divisor, "Please enter the divisor: ");

//             // Output results based on function return
//             if (IsDivisible(dividend, divisor))
//             {
//                 Console.WriteLine("{0} is divisible by {1}.", dividend, divisor);
//             } 
//             else
//             {
//                 Console.WriteLine("{0} is not divisible by {1}.", dividend, divisor);
//             }
//         }
//     }
// }