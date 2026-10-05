// // A program that can determine if an email is valid
// // My criteria: ONLY ONE '@' symbol. Must have at least ONE '.'.
// // The '.' must also be AFTER the @ symbol, NEVER before
// using System;

// namespace csharp_projects
// {
//     class EmailValidator
//     {
//         // This function returns the user's input as a string
//         // given some prompt and that it passes a presence check
//         static string GetInput(string message)
//         {
//             string? userInput;

//             // Input validation
//             while (true)
//             {
//                 Console.Write(message);
//                 userInput = Console.ReadLine();

//                 if (!string.IsNullOrEmpty(userInput))
//                 { // this means it passed the presence check
//                     return userInput;
//                 }

//                 Console.WriteLine("Please enter a value!");
//             }
//         }

//         // This functions returns true/false is the passed parameter
//         // is a valid email address. It must only have one '@' symbol,
//         // and any '.' must be after it. There must be one '.'.
//         static bool IsValidEmail(string email)
//         {
//             // find the first position of the at
//             int atPos = email.IndexOf('@');

//             if (atPos == -1)
//             { // this would imply there are NO @s.
//                 return false;
//             }

//             // the following slice below is the substring after the first @ to the end
//             string stringAfterAt = email[(atPos + 1)..];
            
//             if (stringAfterAt.Contains('@') || !stringAfterAt.Contains('.'))
//             { // this would imply another existance of an @ so 2. Hence false
//                 // this could also imply no dots after the at as well.
//                 return false;
//             }

//             if (email[..(atPos)].Contains('.'))
//             { // this would imply a '.' before the @ symbol so false
//                 return false;
//             }

//             return true;
//         }

//         // Main function of the program 
//         static void Main(string[] args)
//         {
//             string email = GetInput("Enter the email address: ");

//             // output whether or not the email is valid
//             if(IsValidEmail(email))
//             {
//                 Console.WriteLine("{0} is a valid email!", email);
//             } 
//             else
//             {
//                 Console.WriteLine("{0} is not a valid email.", email);
//             }
//         }
//     }
// }