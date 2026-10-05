// // A C# program to solve the infamous problem 'FizzBuzz'.
// // This is done using the moduluo operator and using iteration and selection
// using System;

// namespace csharp_projects
// {
//     class FizzBuzz
//     {
//         // A procedure that outputs the 'FizzBuz' solution
//         // If divisible by 3 then "Fizz", if 5 "Buzz" if both "FizzBuzz"
//         static void OutputFizzBuzz(int limit)
//         {
//             for (int count = 1; count <= limit; count++)
//             {
//                 if (count % 15 == 0)
//                 { // This implies its divisible by both 3 and 5 (15 is their LCM)
//                     Console.WriteLine($"{count}: FizzBuzz");
//                 } else if (count % 3 == 0)
//                 { // This implies only divisible by 3, not 5
//                     Console.WriteLine($"{count}: Fizz"); 
//                 } else if (count % 5 == 0)
//                 { // This implies only divisible by 5, not 3
//                     Console.WriteLine($"{count}: Buzz");
//                 }
//             }
//         }

//         // Main function of the program
//         static void Main(string[] args)
//         {
//             Console.Write("What is the maximum value for fizzbuzz: ");
//             int maxValue = Convert.ToInt32(Console.ReadLine());

//             OutputFizzBuzz(maxValue);
//         }
//     }
// }

