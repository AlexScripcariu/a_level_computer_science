// // A program that clamps a number, given some upper limit
// // This can simulate acceleration in video games, for example
// using System;

// namespace csharp_projects
// {
//     class ClampNumbers
//     {
//         // A procedure that takes in a variable (by ref) and a message
//         // Then the message is displayed, and after passing both
//         // presence and type validation, the input is stored into the variable
//         static void InputVariable(ref int variable, string message)
//         {
//             string userInput = "";
//             // input variable
//             while (true)
//             {
//                 Console.Write(message);
//                 // ?? operator assigns a value if userInput is null
//                 userInput = Console.ReadLine() ?? "";

//                 // presence check
//                 if (string.IsNullOrEmpty(userInput))
//                 {
//                     Console.WriteLine("Please enter a value!");
//                     continue;
//                 }
                
//                 // type check
//                 if (Int32.TryParse(userInput, out variable))
//                 {
//                     return;
//                 }
//                 // outputted if failed type check
//                 Console.WriteLine("Please enter an integer!");
//             }
//         }

//         // A function that takes in a value and an upper limit and 
//         // clamps the value to that upper limit. This is done via the Min().
//         static int Clamp(int value, int UPPER_LIMIT)
//         {
//             // Using math.min to do the clamping process
//             return Math.Min(value, UPPER_LIMIT);
//         }

//         //Main function of the program
//         static void Main(string[] args)
//         {
//             // I have made this a hard-coded constant,
//             // rather than a user input.
//             const int UPPER_LIMIT = 50; // ms^(-2)
//             int currAcceleration = 0; // ms^(-2)
//             InputVariable(ref currAcceleration, "Please enter the current acceleration: ");
            
//             // Output the result of clamping the acceleration
//             int clampedAcceleration = Clamp(currAcceleration, UPPER_LIMIT);

//             Console.WriteLine("{0} clamped to {1} is: {2}", currAcceleration, UPPER_LIMIT, clampedAcceleration);

//         }
//     }
// }