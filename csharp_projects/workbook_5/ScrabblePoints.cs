// // A program that outputs the total points of a word from Scrabble letters
// // This is done by using indexing from an array, and then using iteration.
// using System;

// namespace csharp_projects
// {
//     class ScrabblePoints
//     {
//         // This function takes in a word and using iteration, adds up the total
//         // points gained by that word using scrabble tiles. 
//         static int GetPoints(string word)
//         {
//             // (I am using arrays here, but we have not been taught them yet)
//             // This array gets a given index to a point. 
//             // The index is letter - 'A'
//             // letters:           A, B, C, D, E, F, G, H, I, J, K, L, M,
//             int[] letterPoints = {1, 3, 3, 2, 1, 4, 2, 4, 1, 8, 5, 1, 3,
//             //                    N, O, P, Q,  R, S, T, U, V, W, X, Y, Z
//                                   1, 1, 3, 10, 1, 1, 1, 1, 4, 4, 8, 4, 10};
            
//             int totalPoints = 0;

//             foreach (char letter in word)
//             { // Summing up the total points via iteration
//                 totalPoints += letterPoints[letter - 'A'];
//             }
//             // return points to the user
//             return totalPoints;
//         }

//         // Main function of the program
//         static void Main(string[] args)
//         {
//             Console.Write("Enter the scrabble word: ");
//             string userWord = Console.ReadLine() ?? "";

//             int wordPoints = GetPoints(userWord.ToUpper());

//             // Output the result to the user
//             Console.WriteLine($"{userWord} gives you {wordPoints} {((wordPoints == 1) ? "point" : "points")}");
//         }
//     }
// }

