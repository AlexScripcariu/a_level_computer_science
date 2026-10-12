// // A program that gets a number input and keeps doing the sum of the squares of the digits
// // If the sum is eventually 1, then we print out happy!
// using System;

// namespace csharp_projects
// {
//     class SumOfSqaures
//     {
//         // Helper function for CheckHappy() that gets the sum of digits of a number
//         static int SumOfSqDigits(int value)
//         {
//             int result = 0;

//             while (value > 0)
//             { // using while loop to iterate through all digits
//                 int digit = value % 10; // gets the last digit
//                 result += digit * digit; // add on the digit squared
//                 value /= 10; // move onto the next digit
//             }

//             return result;
//         }

//         // This function checks if a number is happy. This means the sum of squares
//         // of each digit eventually converges to 1.
//         static bool CheckHappy(int startNumber)
//         {
//             int currentNumber = startNumber;

//             for (int i = 0; i < 730; i++)
//             { // loop 730 times according to the pigeonhole principle
//                 if (currentNumber == 1)
//                 { // This means it is 1 forever, so is happy
//                     return true;
//                 }

//                 currentNumber = SumOfSqDigits(currentNumber);
//             }
//             return false;
//         }


//         // Main function of the program
//         static void Main(string[] args)
//         {
//             int userNumber = Input.GetInput("Enter the number to begin: ");

//             bool isHappy = CheckHappy(userNumber);

//             Console.WriteLine($"{userNumber} {(isHappy ? "is" : "is not")} happy");
//         }
//     }
// }

