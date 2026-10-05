// // A program that generate 3 dice rolls and then 
// // calculate a score based on the roll
// using System;

// namespace csharp_projects
// {
//     class DiceGame
//     {
        
//         // A function that generates and returns a dice roll
//         static int RollDie()
//         {
//             Random x = new Random();
//             return x.Next(1, 7); // remember range is exclusive
//         }

//         // A function that returns the total score of rolling 3 dice
//         // if 3 match: return sum. if 2 match: return their sum - the other
//         // if none match: return 0
//         static int ScoreDice(int Dice1, int Dice2, int Dice3)
//         {
//             // using selection
//             if (Dice1 == Dice2 && Dice2 == Dice3)
//             {
//                 // if all equal, return their sum
//                 return Dice1 + Dice2 + Dice3;
//             } 
//             else if (Dice1 == Dice2 && Dice1 != Dice3) 
//             {
//                 return Dice1 + Dice2 - Dice3;
//             } 
//             else if (Dice2 == Dice3 && Dice3 != Dice1)
//             {
//                 return Dice2 + Dice3 - Dice1;
//             } 
//             else if (Dice1 == Dice3 && Dice3 != Dice2)
//             {
//                 return Dice1 + Dice3 - Dice2; 
//             } 
//             else
//             {
//                 // As none match, return 0
//                 return 0;
//             }
//         }

//         // Main function of the program
//         static void Main(string[] args)
//         {
//             // we could use arrays, but I have not been taught that yet
//             // So i have refrained from using them, also there are only 3 items.
//             int roll1 = RollDie();
//             int roll2 = RollDie();
//             int roll3 = RollDie();

//             int totalScore = ScoreDice(roll1, roll2, roll3);

//             // Output the total score by using formatting
//             Console.WriteLine("You rolled a: {0}, {1}, {2} and scored a {3}",
//             roll1, roll2, roll3, totalScore);
//         }
//     }
// }