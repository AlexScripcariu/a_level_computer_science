// // A program that generates a password given a word. All indexes from each vowel
// // Are concatenated together to form the new password. This uses iteration and 
// // Arrays to determine the final password
// using System;

// namespace csharp_projects
// {
//     class PasswordGenerator
//     {
//         // This function takes in a string, and all indexes that have a vowel
//         // are concatenated together and returned
//         static string GeneratePassword(string text)
//         {
//             // Using boolean arrays to determine if a letter is a vowel or not
//             bool[] isVowel = new bool[26];
//             isVowel[0] = isVowel['E' - 'A'] = isVowel['I' - 'A'] = isVowel['O' - 'A'] = isVowel['U' - 'A'] = true;

//             string finalPassword = "";

//             for (int i = 0; i < text.Length; i++)
//             {
//                 if (text[i] - 'A' >= 0 && text[i] - 'A' < 26 && isVowel[text[i] - 'A'])
//                 { // This means that the letter is a letter and not something like a ' ' character
//                     finalPassword += Convert.ToString(i);
//                 }
//             } 

//             // return the gen. password
//             return finalPassword;
//         }

//         // Main function of the program
//         static void Main(string[] args)
//         {
//             // Get the original word from the user
//             Console.Write("Enter the first word to map to your password: ");
//             string originalWord1 = Console.ReadLine() ?? "";
//             Console.Write("Word 2: ");
//             string originalWord2 = Console.ReadLine() ?? "";

//             string newPassword = GeneratePassword(originalWord1.ToUpper());
//             newPassword += GeneratePassword(originalWord2.ToUpper());

//             // Output the new password to the user
//             Console.WriteLine($"{originalWord1} {originalWord2} maps to a password of {newPassword}");
//         }
//     }
// }


