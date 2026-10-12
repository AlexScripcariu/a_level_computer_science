// // A program that converts a number from denary to binary
// // This is done by dividing by two and adding the remainder to the new number
// using System;

// namespace csharp_projects
// {
//     class DenToBin
//     {
//         // This function returns a binary-formatted number in the form of an integer
//         // The binary number can be obtained by doing repeated division and storing 
//         // The remainder
//         static int ConvertToBinary(int denary)
//         {
//             int currentPow = 1; // represents the 10 power multiplier(1, 10, 100,...)
//             int result = 0;

//             while (denary > 0)
//             { // keep looping unti nothing left to divide
//                 // we add the remainder onto the result
//                 // We add 10 * digits * remainder as that is the next position
//                 // at the front (digit math).
//                 result += currentPow * (denary % 2);

//                 denary /= 2; 
//                 currentPow *= 10;
//             }

//             return result;
//         }

//         // Main function of the program
//         static void Main(string[] args)
//         {
//             int denaryNum = Input.GetInput("Enter the denary number to convert: ");

//             int binaryNum = ConvertToBinary(denaryNum);

//             // Output the result to the console
//             Console.WriteLine($"{denaryNum} to binary is {binaryNum}");
//         }
//     }
// }

