// // A program that takes in a string and displays it using ASCII art
// using System;

// namespace csharp_projects
// {
//     class ASCIIArt
//     {
//         // This is a is a helper procedure for the DisplayArt() procedure
//         // This is done to improve code modularity
//         static void DisplayEdgeRow(string text)
//         {
//             Console.Write('+');
//             for (int i = 0; i < text.Length; i++) Console.Write("-+"); 
//             Console.Write('\n');
//         }

//         // A procedure that displays ASCII art given some text:
//         // +-+-+-+-+-+ <-- Example
//         // |H|E|L|L|O|
//         // +-+-+-+-+-+
//         static void DisplayArt(string text)
//         {
//             // Output the top row: + and '+-' text.Length times
//             DisplayEdgeRow(text);
//             // One line for conciseness ^^^

//             // Middle row:
//             Console.Write('|');
//             foreach (char letter in text) {
//                 Console.Write(Convert.ToString(letter) + "|");
//             }
//             Console.Write('\n');

//             // Bottom row:
//             DisplayEdgeRow(text);
//         }

//         // Main function of the program
//         static void Main(string[] args)
//         {
//             // Get user Input
//             Console.Write("Please enter the text for ASCII art: ");
//             String userInput = Console.ReadLine() ?? "";


//             DisplayArt(userInput);
//         }
//     }
// }