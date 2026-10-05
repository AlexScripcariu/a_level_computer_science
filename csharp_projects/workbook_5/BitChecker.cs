// // This program mimicks how you can check if a bit is corrupted by 
// // an odd parity check
// using System;

// namespace csharp_projects
// {
//     class BitChecker
//     {
//         // This functions takes in a binary string (a string of only 1's and 0's)
//         // If the number of 1's is odd, then it returns true, otherwise false
//         static bool OddParity(string binaryString)
//         {
//             int oneCount = 0;

//             foreach (char letter in binaryString)
//             {
//                 if (letter == '1') oneCount++;
//             }


//             // return True if the number of 1's is odd
//             if (oneCount % 2 == 1) return true;
            
//             return false;
//         }

//         // Main function of the program
//         static void Main(string[] args)
//         {
//             // get the binary string from the user input
//             Console.Write("Enter the binary string of 1's and 0's: ");
//             string binaryString = Console.ReadLine() ?? "";


//             bool isOdd = OddParity(binaryString);

//             // Output whether or not there is an odd parity in the numbers
//             Console.WriteLine($"There is an {((isOdd) ? "odd" : "even")} parity of 1's in {binaryString}");
//         }
//     }
// }


