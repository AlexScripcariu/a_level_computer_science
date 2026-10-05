// // A program that can determine the total amount of full days
// // given X hours. 24 hours per day. So days = hours / 24 (floored)
// using System;

// namespace csharp_projects
// {
//     class HoursInDay
//     {
//         // This procedure asks for user input, given some message
//         // and stores the input (if it has passed validation)
//         // into the given variable parameter
//         static void GetInput(ref int var, string message)
//         {
//             // a ? is used to indicate the string can also be null
//             // (used to ignore the error from inputting)
//             string? userInput;

//             // Validating the input
//             while (true)
//             {
//                 Console.Write(message);
//                 userInput = Console.ReadLine();

//                 if (string.IsNullOrEmpty(userInput))
//                 {
//                     Console.WriteLine("Please enter a value!");
//                     continue;
//                 } 
//                 else if (Int32.TryParse(userInput, out var) && var >= 0)
//                 {
//                     // This acts as both a type and limit check
//                     // As the first part of the condition is executed first
//                     // This implies the var is an int when compared to 0
//                     return;
//                 }
//                 Console.WriteLine("Please enter an integer!");
//             }
//         }

//         // This function takes in an integer number of hours and tells you the
//         // total number of whole days that have passed.
//         static int HoursToDays(int hours)
//         {
//             // using the formula: days = hours /24
//             return hours / 24; // a single / is automatically floor division in c#
//         }

//         // Main function of the program
//         static void Main(string[] args)
//         {
//             int totalHours = 0;
//             GetInput(ref totalHours, "Enter the number of hours: ");    

//             int totalDays = HoursToDays(totalHours);

//             // Output the answer to the console
//             Console.WriteLine("{0} hours is {1} whole day(s)", totalHours, totalDays);
//         }
//     }
// }
