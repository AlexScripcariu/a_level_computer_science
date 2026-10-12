// // A program that takes in some constants and an original population of predator and prey
// // And outputs how the number of predators changes with the number of prey (and vice versa)
// using System;

// namespace csharp_projects
// {
//     class PredatorPrey
//     {
//         // This procedure simulates the natural rise and fall of predator-prey
//         // relationships. It uses a model to determine the populations of 
//         // predators and prey.
//         static void SimulateCycle(int prey, int predators, int generations, double A, double B, double C, double D, double E)
//         {
//             int currPrey = prey;
//             int currPred = predators;
//             int generation = 1;

//             // Declaring variables here to avoid constant memory allocation
//             double preyGrowth;
//             double predGrowth;

//             while (currPrey >= 2 && currPred >= 2 && generation <= generations)
//             { // This will keep displaying generations as long as both pop's are >= 2
//                 // Grow the populations
//                 preyGrowth = Math.Round(Math.Pow(E, A - (C * currPred)), 2);
//                 currPrey = Convert.ToInt32((currPrey * preyGrowth));
//                 predGrowth = Math.Round(Math.Pow(E, (C * D * currPrey) - B), 2);
//                 currPred = Convert.ToInt32((currPred * predGrowth));

//                 // Output the new populations
//                 Console.WriteLine($"Generation {generation}: {preyGrowth} Prey | {predGrowth} Pred");
//                 Console.WriteLine($"Generation {generation}: {currPrey} prey | {currPred} predators");
//                 generation++;
//             }
//         }

//         // Main function of the program
//         static void Main(string[] args)
//         {
//             // I will not input these values as they are hard-coded into the problem
//             int totalPrey = 30;
//             int totalPredators = 5;

//             int totalGenerations = Input.GetInput("Enter the number of generations to simulate: ");

//             // procedure to simulate the cycles
//             SimulateCycle(totalPrey, totalPredators, totalGenerations, 0.8, 0.5, 0.1, 0.3, 2.718);
//         }
//     }
// }