// // A program that validates if a password meets certain criteria
// using System;

// namespace csharp_projects
// {
//     class PasswordChecker
//     {
//         // Helper function that returns a boolean if a certain character
//         // satisfies some ASCII value range. If we want to made checks more 
//         // complex, we could use maps or just make specific functions.
//         static bool ContainsX(string text, int lowerBound, int upperBound)
//         {
//             for (int i = 0; i < text.Length; i++)
//             { // loops through all characters
//                 if (lowerBound <= text[i] && text[i] <= upperBound)
//                 { // implies character was found between these ranges
//                     return true;
//                 }
//             }

//             // Code reached if no value was found in ASCII range
//             return false;
//         }

//         // This function keeps asking the user for a password
//         // until it meets these 3 criteria: >= 8 chars, one upper, one lowercase
//         // and one number
//         static string GetPassword()
//         {
//             string password;
//             while (true)
//             { // this is done so we keep looping until we get a valid answer
//                 password = Input.GetStrInput("Enter your password: ");
                
//                 if (password.Length < 8)
//                 { // length check
//                     Console.WriteLine("Password too short! Min. 8 chars!");
//                     continue;
//                 }

//                 if (!ContainsX(password, (int)'A', (int)'Z'))
//                 { // checks for uppercase
//                     Console.WriteLine("At least one character must be uppercase!");
//                     continue;
//                 }
                
//                 if (!ContainsX(password, (int)'a', (int)'z'))
//                 { // checks for lowercase
//                     Console.WriteLine("At least one character must be lowercase!");
//                     continue;
//                 }

//                 if (!ContainsX(password, (int)'0', (int)'9'))
//                 { // checks for numbers
//                     Console.WriteLine("There must be at least one number!");
//                     continue;
//                 }

//                 return password; // passed all 4 checks
//             }
//         }


//         // Main function of the program
//         static void Main(string[] args) 
//         {
//             string userPassword = GetPassword();
//             Console.WriteLine($"Password set to: {userPassword}");
//         }
//     }
// }
