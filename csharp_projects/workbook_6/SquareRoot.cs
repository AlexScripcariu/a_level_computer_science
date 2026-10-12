// // A program that can input a number and calculate its square root to 4dp
// using System;

// namespace csharp_projects
// {
//     class SquareRoot
//     {
//         // A function that returns the square root of a number using Newton's method
//         // This keeps doing 1/2 of x + 1/x until two consec. values match
//         static double GetRoot(double userNumber)
//         {
//             double curRoot = userNumber;
//             double prevRoot = -1; // arbitrary number

//             while (curRoot != prevRoot)
//             { // This keeps looping as long as they new value is not the same as the other one
//                 prevRoot = curRoot;
//                 curRoot = 0.5 * (curRoot + (userNumber/curRoot));
//             }

//             return curRoot;
//         }

//         // Main function of the program
//         static void Main(string[] args)
//         {
//             int userNumber = Input.GetInput("Enter the number to square root: ");

//             double root = GetRoot(userNumber);

//             // Output the result to the console
//             Console.WriteLine($"{userNumber} rooted is {root:0.0000} to 4 decimal places");
//         }
//     }
// }

