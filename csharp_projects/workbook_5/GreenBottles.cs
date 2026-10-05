// // A program that outputs the text to the popular song 'green bottles'
// using System;

// namespace csharp_projects
// {
//     class GreenBottles
//     {
//         // A procedure that outputs the text to the green bottles song
//         static void DisplayGreenBottles(int bottles)
//         {
//             for (int i = bottles; i > 0; i--)
//             {
//                 // also determines if there is a plural to bottle

//                 for (int j = 0; j < 2; j++)
//                 { // Using iteration to output the first line twice
//                     Console.WriteLine($"{i} green {((i == 1) ?  "bottle" : "bottles")} hanging on the wall, ");
//                 }
                
//                 Console.WriteLine("And if one green bottle should accidentally fall,");

//                 Console.WriteLine($"There'll be {i - 1} green {((i == 2) ? "bottle" : "bottles")} hanging on the wall\n");
//             }
//         }

//         // Main function of the program
//         static void Main(string[] args)
//         {
//             // Get user input
//             Console.Write("Enter the number of bottles: ");
//             int totalBottles = Convert.ToInt32(Console.ReadLine());

//             // Output the result
//             DisplayGreenBottles(totalBottles);
//         }
//     }
// }

