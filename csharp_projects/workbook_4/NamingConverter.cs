// // A program that takes in two words and a given naming convention
// // (kebab, snake, camel or pascal) and then outputs the value in that convention
// // e.g. hello, world, kebab = hello-world
// using System;

// namespace csharp_projects
// {
//     class NamingConverter
//     {
//         // Helper function for GetInput
//         // A function that takes in a string and returns the number of ' ' 
//         // space characters present in the string, via iteration
//         static int GetSpaceCount(string message)
//         {
//             int spaceCount = 0;
            
//             for (int i = 0; i < message.Length; i++)
//             {
//                 if (message[i] == ' ')
//                 { // this implies the current index is a space character
//                     spaceCount++;
//                 }
//             }

//             return spaceCount; // return the total count
//         }

//         // This function returns the user's input as a string from a given prompt
//         // The string will undergo a presence check and also make sure the first letter
//         // of each input is not a number (rules for creating identifiers) (and no spaces!)
//         static string GetInput(string message)
//         {
//             string? userInput;

//             // input validation
//             while (true)
//             {
//                 Console.Write(message);
//                 userInput = Console.ReadLine();

//                 if (!string.IsNullOrEmpty(userInput))
//                 { // inside this code means presence check passed
//                     if (char.IsNumber(userInput[0]))
//                     {
//                         Console.WriteLine("The first character of the input cannot be a number!");
//                         continue;
//                     }
//                     if (GetSpaceCount(userInput) != 0)
//                     {
//                         Console.WriteLine("No spaces are allowed in the input!");
//                         continue;
//                     }
//                     // reaching here implies all checks passed
//                     return userInput;
//                 }
//                 // reaching here implies no input sent
//                 Console.WriteLine("Please enter a value!");
//             }
//         }

//         // This is a helper function for InputConvetion.
//         // This uses selection to determine if the convention is valid
//         // It returns true if so, allowing InputConvention to finish
//         static bool ValidConvention(string convention)
//         {
//             // 1. I could iterate through an array (would be more maintainable and readable)
//             // but I have not been exposed to them yet
//             // 2. The if statement is a bit long, but also condenses the cases so the code isn't incredibly long
//             if (convention == "kebab" || convention == "pascal" || convention == "snake" || convention == "camel")
//             {
//                 return true;
//             }

//             return false;
//         }

//         // This function repeatedly asks for the naming convention to use (pascal, kebab, camel, snake)
//         // It keeps asking until the user's input (lowercased) matches. It uses the GetInput() function inside
//         // Then it returns the selected case
//         static string InputConvention(string message)
//         {
//             string userInput = "";
//             while (!ValidConvention(userInput)) // checks if the input matches one of the 4 conventions
//             {
//                 userInput = GetInput(message).ToLower();
//             }

//             return userInput;
//         }   

//         // Helper function that capitalises a string. Similar to python version.
//         // "hELLo WorlD" --> "Hello World"
//         static string Capitalise(string message)
//         {
//             return Convert.ToString(message[0]).ToUpper() + message[1..].ToLower();
//         }

//         // 4 Helper functions to ConvertToConvetion below:
//         // id1 = identifier1, id2 = identifier 2

//         // 1. To pascal means stringa, stringb -> StringaStringb
//         static string ToPascalCase(string id1, string id2)
//         {
//             return Capitalise(id1) + Capitalise(id2);
//         }

//         // 2. To kebab means tringa, stringb -> stringa-stringb
//         static string ToKebabCase(string id1, string id2)
//         {
//             return id1.ToLower() + "-" + id2.ToLower();
//         }

//         // 3. To camel means stringa, stringb -> stringaStringB
//         static string ToCamelCase(string id1, string id2)
//         {
//             return id1.ToLower() + Capitalise(id2);
//         }

//         // 4. To snake means stringa, stringb -> stringa_stringb
//         static string ToSnakeCase(string id1, string id2)
//         {
//             return id1.ToLower() + "_" + id2.ToLower();
//         }

//         // This function takes in the naming convention and uses a switch to determine which helper function to call
//         // From the return of the helper function, it then returns that value as the new identifier name
//         static string ConvertToConvention(string identifier1, string identifier2, string namingConvention)
//         {
//             switch (namingConvention)
//             {
//                 case "pascal":
//                     return ToPascalCase(identifier1, identifier2);
//                 case "kebab":
//                     return ToKebabCase(identifier1, identifier2);
//                 case "camel":
//                     return ToCamelCase(identifier1, identifier2);       
//                 case "snake":
//                     return ToSnakeCase(identifier1, identifier2);
//                 default:
//                     return "";
//             }
//         }


//         // Main function of the program
//         static void Main(string[] args)
//         {
//             string identifier1 = GetInput("Enter the first identifier: ");
//             string identifier2 = GetInput("Enter the second identifier: ");
//             string namingConvention = InputConvention("Enter the naming convetion (pascal, kebab, camel, snake)");

//             string newIdentifier = ConvertToConvention(identifier1, identifier2, namingConvention);

//             // Output the result to the console
//             Console.WriteLine("{0} and {1} to {2} case is {3}", identifier1, identifier2, namingConvention, newIdentifier);
//         }
//     }
// }