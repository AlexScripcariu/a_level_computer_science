// // This program generates 10 random spots in an 8x8 matrix and then 
// // asks the user to take a guess. If they get all 10 spots within 50
// // guesses they win
// using System;

// namespace csharp_projects
// {
//     class TanksProblem
//     {
//         static int[,] grid = new int[8, 8];
        
//         // This procedure generates the 10 locations for the grid via random library
//         static void GenerateGrid()
//         {
//             Random random = new();
//             int xPos = -1, yPos = -1;

//             // generate all 10 spots via iteration
//             for (int i = 0; i < 10; i++)
//             {
//                 xPos = random.Next(0, 8);
//                 yPos = random.Next(0, 8);
//                 grid[xPos, yPos] = 1; // 1 represents a ship at that pos
//             }

//         }

//         // This procedure plays the tank problem game
//         // It keeps asking the user to guess locations
//         // if they get all 10 spots within 50 moves, then they would output
//         // that they won
//         static void PlayGame()
//         {
//             int totalFound = 0;

//             for (int guess = 1; guess <= 50; guess++)
//             {
//                 int userX = Input.GetInput("Enter the X position(0-7): ", 0, 7);
//                 int userY = Input.GetInput("Enter the Y position(0-7): ", 0, 7);

//                 if (grid[userX, userY] == 1)
//                 { // checks if location is a ship
//                     totalFound++;
//                     Console.WriteLine("HIT!");
//                     if (totalFound == 10)
//                     { // This implies all ships were found
//                         Console.WriteLine($"You win! It took {guess} guesses!");
//                         return;
//                     }
//                     grid[userX, userY] = 0; // so the ship can no longer be guessed
//                 } else
//                 {
//                     Console.WriteLine("MISS!");
//                 }
//             }


//             // This part of code is reached if more than 50 guesses and not all ships found
//             Console.WriteLine($"Sorry! You lost. You only guessed {totalFound} out of the 10.");
//         }

//         // Main function of the program 
//         static void Main(string[] args)
//         {
//             // Generate the 10 spots
//             GenerateGrid();

//             // Play the game
//             PlayGame();

//         }
//     }
// }