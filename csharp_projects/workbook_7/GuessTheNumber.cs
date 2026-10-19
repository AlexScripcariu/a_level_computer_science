// // A program that allows a user to keep guessing a number between 1 and 100
// using System;

// namespace csharp_projects
// {
//     class GuessTheNumber
//     {
//         // A procedure that plays the whole guessing game
//         // Defined for modularity
//         static void PlayGame() 
//         {
//             // Declare variables
//             int userGuesses = 0;
//             Random RNG = new();
//             int computerNum = RNG.Next(1, 101);
//             int playerGuesses = 0;

//             while (true) 
//             { // Keep looping guesses until the user gets the right number
//                 playerGuesses = Input.GetInput("Guess a number between 1-100: ", 1, 100);
//                 userGuesses++;       

//                 if (playerGuesses != computerNum) 
//                 { // Output a wrong guess message
//                     Console.WriteLine("Invalid guess!, Try again!");
//                 } else
//                 {
//                     break; // Exit the loop if the user guesses the right number
//                 }
//             }

//             Console.WriteLine($"Congrats! You guessed {computerNum} after {playerGuesses} {((playerGuesses != 1) ? "guesses" : "guess")}!");
//         }


//         // Main function of the program
//         static void Main(string[] args) 
//         {
//             PlayGame();
//         }
//     }
// }
