// // A program that can determine if a number is prime via a linear root primality search:
// using System;

// namespace csharp_projects
// {
//     class PrimalityChecker
//     {
//         // Function that returns a bool on whether or not a number is prime.
//         // Performs a linear check up to root n. Hence time complexity: O(root(n))
//         static bool IsPrime(int num)
//         {
//             // We only need to check up to the root of n
//             // Full explanation on slide
//             for (int i = 2; i * i <= num; i++)
//             {
//                 if (num % i == 0) return false; // implies num has another divisor
//                 // so not prime
//             }

//             return true;
//         }

//         // Main function of the program
//         static void Main(string[] args)
//         {
//             // Get user input for a number: 
//             //Console.Write("Enter the number to check if its prime: ");
//             //int userInt = Convert.ToInt32(Console.ReadLine());

//             // Test numbers within a given range: 
//             for (int i = 1; i <= 100; i++)
//             {
//                 bool isPrimeNum = IsPrime(i);
//                 // output if the numebr is/isn't prime
//                 Console.WriteLine($"{i} {((isPrimeNum) ? "is" : "is not")} prime.");
//             }
            
//         }
//     }
// }

