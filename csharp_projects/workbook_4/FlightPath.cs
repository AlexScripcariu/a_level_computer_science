// // A program that takes in a start and end location
// // Then it outputs their first 4 letters combined with a dash
// // This is to simulate what an airport ticket would be like
// using System;

// namespace csharp_projects
// {
//     class FlighPath
//     {
//         // A function that prompts a user for an input given a message
//         // if it passes a presence check, the input is returned.
//         static string GetInput(string message)
//         {
//             string? userInput;
            
//             // input validation
//             while (true)
//             {
//                 Console.Write(message);
//                 userInput = Console.ReadLine();

//                 if (!string.IsNullOrEmpty(userInput))
//                 { // runs if passed presence check
//                     return userInput;
//                 }

//                 Console.WriteLine("Please enter an input!");
//             }
//         }

//         // helper function to generate city codes for the GetTicket function
//         static string CityCode(string city)
//         {
//             return city[..Math.Min(4, city.Length)].ToUpper();
//         }
        
//         // a function that takes in the two cities and then produces
//         // an 'airline ticket' which is returned. This done by concatenating
//         // the first 4 (or length in total) chars (upper) of each place with a '-'  
//         static string GetTicket(string city1, string city2) 
//         {
//             string city1Code = CityCode(city1);
//             string city2Code = CityCode(city2);
//             return city1Code + '-' + city2Code;
//         }

//         // Main function of the program
//         static void Main(string[] args)
//         {
//             // Get the user input
//             string departAirport = GetInput("What city are you departing from?: ");
//             string arrivalAirport = GetInput("What city are you arriving to?: ");

//             string airlineTicket = GetTicket(departAirport, arrivalAirport);

//             // Output their 'ticket' to the console.
//             Console.WriteLine("From {0} to {1} is: {2}", departAirport, arrivalAirport, airlineTicket);
//         }
//     }
// }