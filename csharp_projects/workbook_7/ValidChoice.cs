// // A program that keeps prompting the user for an input until a valid one is given
// using System;

// namespace csharp_projects
// {
//     class ValidChoice
//     {
//         // Function to return a valid input
//         static string GetInput()
//         {
//             Console.WriteLine("a. Option A");
//             Console.WriteLine("b. Option B");

//             bool valid = false;
//             string choice = "";

//             while (!valid) 
//             {
//                 Console.WriteLine("Enter an option: ");
//                 choice = Console.ReadLine();

//                 if ((choice == "a") || (choice == "b")) {
//                     valid = true;
//                 }
//                 else 
//                 {
//                     Console.WriteLine("Invalid option chosen. Try again.");
//                 }
//             }

//             return choice;
//         }


//         // Main function of the program
//         static void Main(string[] args) 
//         {
//             string choice = GetInput();

//             Console.WriteLine("You chose option {0}.", choice);
//         }
//     }
// }
