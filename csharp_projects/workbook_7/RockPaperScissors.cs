// // A program that simulates the rock, paper, scissors game against a computer
// using System;

// namespace csharp_projects
// {
//     class RockPaperScissors
//     {
//         // This is a sub-procedure for PlayGame. This simulates
//         // One round of RPS where the CPU plays the user, then the scores
//         // are adjusted. PlayRound returns 1 if player wins, -1 if comp wins, 0 for draw
//         static int PlayRound()
//         {
//             // I will map the options to integers;
//             // Rock = 0, paper = 1 , scissors = 2
//             Random RNG = new();
//             int computerChoice = RNG.Next(1, 4);

//             string userChoice;
//             int userValue = -1;
//             // validate user Choice
//             while (true)
//             {
//                 userChoice = Input.GetStrInput("Enter 'rock', 'paper', or 'scissors': ").ToLower();
//                 if (userChoice != "rock" && userChoice != "paper" && userChoice != "scissors")
//                 {
//                     Console.WriteLine("Please enter one of the 3 options!");
//                     continue;
//                 }
//                 // map string to int
//                 if (userChoice == "rock") userValue = 0;
//                 else if (userChoice == "paper") userValue = 1;
//                 else userValue = 2;
//                 break;
//             }

//             // calc winner
//             if (userValue == computerChoice) return 0;
//             else if ((userValue == 2 && computerChoice == 1) || 
//                     (userValue == 0 && computerChoice == 2) || 
//                     (userValue == 1 && computerChoice == 0)) return 1;
//             else return -1;
//         }


//         // This procedure runs a full game of RPS and outputs
//         // the results (user and CPU score) to the consoles
//         static void PlayGame()
//         {
//             int userScore = 0;
//             int computerScore = 0;

//             while (userScore < 10 && computerScore < 10)
//             { // keep looping until either one has a score of 10.
//                 int res = PlayRound();
//                 if (res == 1) userScore++;
//                 else if (res == -1) computerScore++; // This implies PlayRound = false
//             }

//             // output the winner
//             if (userScore == 10) Console.WriteLine("Winner: you!");
//             else Console.WriteLine("Winner: Computer.");

//             // output scores
//             Console.WriteLine($"Your score: {userScore}");
//             Console.WriteLine($"Computer's score: {computerScore}");
//         }

//         // Main function of the program
//         static void Main(string[] args) 
//         {
//             PlayGame(); // extracted procedure for game
//         }
//     }
// }
