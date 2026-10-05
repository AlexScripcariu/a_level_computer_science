// // a program that outputs the roll of an n-sided die
// using System;

// namespace csharp_projects
// {
//     class PolyhedralDice
//     {
//         // A procedure that will input an int, and store it to a variable​
//         // This will also undergo validation: presence + type ​
//         // The variable is also pass-by-reference​
//         static void InputVariable(ref int variable, string message)
//         {
//             string userInput = "";
//             // input validation​
//             while (true)
//             {
//                 Console.Write(message);
//                 // ?? operator assigns a value if userInput is null
//                 userInput = Console.ReadLine() ?? "";

//                 // presence check​
//                 if (string.IsNullOrEmpty(userInput))
//                 {
//                     Console.WriteLine("Please enter a value!");
//                     continue;
//                 }
            
//                 // type check​
//                 if (Int32.TryParse(userInput, out variable))
//                 {
//                     return; 
//                 }
//                 // outputted if failed the type check
//                 Console.WriteLine("Please enter an integer!");
//             }
//         }

//         // A function that returns a randomly generated number between 1 and the argument
//         static int RollDie(int sides)
//         {
//             Random x = new Random();
//             // return a random roll, remembering the upper bound is exclusive
//             return x.Next(1, sides + 1);
//         }

//         // Main function of the program
//         static void Main(string[] args)
//         {
//             int numberOfSides = 0;
//             // assigning the variable
//             InputVariable(ref numberOfSides, "Enter the number of sides of the die: ");

//             // Outputting the roll, using formatting
//             Console.WriteLine("Number rolled: {0}", RollDie(numberOfSides));
//         }
//     }
// }
