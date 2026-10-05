// // A program that can determine if a year is also a leap year
// // This is done by determining its divisibility (hence I've used MOD)
// using System;

// namespace csharp_projects
// {
//     class LeapYear
//     {
//         // This procedure takes in a variable to modify and a message
//         // The message is displayed, and the user is prompted to input
//         // The user will continue to be prompted until the input
//         // passes a presence and type check, from which the input
//         // will be assigned to the variable
//         static void InputVariable(ref int variable, string message)
//         {
//             string userInput;
//             // input validation
//             while (true)
//             {
//                 Console.Write(message); // display message
//                 userInput = Console.ReadLine() ?? ""; // get user input

//                 // presence check
//                 if (string.IsNullOrEmpty(userInput))
//                 {
//                     Console.WriteLine("Please enter a value!");
//                     continue;
//                 }
                
//                 // type check
//                 if (Int32.TryParse(userInput, out variable) && variable >= 0)
//                 {
//                     return; // successful input
//                 }
//                 // code is reached if data type is not Int32
//                 Console.WriteLine("Please enter an integer!");
//             }
//         }

//         // A function that returns true/false if the given year
//         // is a leap year. Conditions: divisible by 4 and
//         // not divisible by 100, or divisible by 400.
//         static bool IsLeapYear(int year)
//         {
//             if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
//             {
//                 return true;
//             }
//             return false;
//         } 

//         // Main function of the program
//         static void Main(string[] args)
//         {
//             int year = 0;
//             InputVariable(ref year, "Enter the year: ");

//             // output the result of the function
//             if (IsLeapYear(year))
//             {
//                 Console.WriteLine("{0} is a leap year.", year);
//             } 
//             else
//             {
//                 Console.WriteLine("{0} is not a leap year.", year);
//             }
//         }
//     }
// }