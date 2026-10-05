// // A program that takes the names of person and outputs
// // their initials in all capitals. It first asks the user for their 1st, 2nd
// // and 3rd name, and then combines them to get their intials
// using System;

// namespace csharp_projects
// {
//     class InitialGenerator
//     {
//         // This function prompts the user to enter an input
//         // given some message. If it passes a presence check, the value is returned
//         // isPresence is to determine if a presence check is needed
//         static string GetInput(string message, bool isPresence)
//         {
//             string? userInput;
            
//             // input validation
//             while (true)
//             {
//                 Console.Write(message);
//                 // if null then input = empty string
//                 userInput = Console.ReadLine() ?? "";

//                 if (!string.IsNullOrEmpty(userInput) || !isPresence)
//                 { // reaches here if passed presence check (or if check not needed)
//                     return userInput;
//                 }  
//                 // message if nothing was inputted!
//                 Console.WriteLine("Please enter a value!");
//             }
//         }

        
//         // This is a helper function for the GetInitials function
//         // This just returns the uppercased first letter.
//         static string Letter(string name)
//         {
//             return Convert.ToString(name[0]).ToUpper();
//         }


//         // This function takes the first character of each argument
//         // capitalises them and concatenates them. It returns that result.
//         static string GetInitials(string forename, string middleName, string lastName)
//         {
//             return Letter(forename) + Letter(middleName) + Letter(lastName);
//         }

//         // Main function of the program
//         static void Main(string[] args)
//         {
//             // Get user input to get their name
//             string forename = GetInput("Enter your forename: ", true);
//             string middleName = GetInput("Enter your middle name: ", false);
//             string lastName = GetInput("Enter your last name: ", true);

//             if (middleName == "")
//             { // This implies no middle name
//                 middleName = "Z";
//             }

//             string initials = GetInitials(forename, middleName, lastName);

//             Console.WriteLine("{0} {1} {2} is {3}", forename, middleName, lastName, initials); 
//         }
//     }
// }