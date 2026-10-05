// // A program that takes a person's first and last name (separated by a space)
// // and then returns the person's first and last name as two separate strings.
// using System;

// namespace csharp_projects
// {
//     class NameSplitter
//     {

//         // Helper function for GetInput
//         // This functions returns true if there is ONLY ONE space between
//         // the index of 1 to n - 2 (inclusive). This acts as a bespoke check for the name
//         static bool SpaceFreqCheck(string name)
//         {
//             int spaceFreq = 0;

//             for (int i = 1; i < name.Length - 1; i++)
//             {
//                 if (name[i] == ' ')
//                 {
//                     spaceFreq++;
//                 }    
//             }

//             if (spaceFreq == 1)
//             { // if only one was detected, then return true. Only valid case
//                 return true;
//             }

//             return false;
//         }


//         // A function that prompts the user for an input given a message
//         // If this input passes a presence check, and between indexes 1 -> n - 2,
//         // there is only 1 space character, then return true
//         static string GetInput(string message)
//         {
//             string? userInput;

//             // validate input
//             while (true)
//             {
//                 Console.Write(message);
//                 userInput = Console.ReadLine();

//                 if (!string.IsNullOrEmpty(userInput))
//                 { 
//                     if (SpaceFreqCheck(userInput))
//                     { // passed the presence and space checks 
//                         return userInput;
//                     }
                    
//                     Console.WriteLine("Please have only 1 space between your names!");
//                     continue;
//                 }
                
//                 Console.WriteLine("Please enter a value!");

//             }
//         }

//         // A function that takes in a full name and returns two
//         // separate strings, the first and second name respectively
//         // This is done by using C# slicing up to and also after the space.
//         // The input has a space as a delimiter
//         static (string, string) SplitName(string fullName)
//         {
//             // first name is everything up to the space
//             // last name is everything after the space
//             int spaceIndex = fullName.IndexOf(' ');

//             return (fullName[..spaceIndex], fullName[(spaceIndex + 1)..]);
//         }
        
//         // Main function of the program 
//         static void Main(string[] args)
//         {
//             string fullName = GetInput("Enter your first and last name separated by a space: ");

//             (string firstName, string lastName) = SplitName(fullName);
            
//             // Output result to console
//             Console.WriteLine("Your name split is {0} and {1}", firstName, lastName);
//         }
//     }
// }
