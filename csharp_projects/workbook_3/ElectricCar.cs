// // A program that calculates the cost of charging an electric car
// // while shopping. Additonally, it also calculates the points gained,
// // which can then be used for shopping.
// using System;
// using System.ComponentModel.DataAnnotations;

// namespace csharp_projects
// {
//     class ElectricCar
//     {
//         // This procedure takes in the variable to change and a message
//         // Then it takes user input, and once it has passed a:
//         // presence, type and limit check, then it assigns the user input
//         // to the variable.
//         static void GetInput(ref double variable, string message)
//         {
//             string? userInput;

//             // validation checks
//             while (true)
//             {
//                 Console.Write(message);
//                 userInput = Console.ReadLine();

//                 // presence check
//                 if (string.IsNullOrEmpty(userInput))
//                 {
//                     Console.WriteLine("Please enter a value!");
//                     continue;
//                 } // Type check
//                 else if (Double.TryParse(userInput, out variable))
//                 {
//                     if (variable <= 0) // limit check
//                     {
//                         Console.WriteLine("Please enter a positive value!");
//                         continue;
//                     }
//                     return;
//                 }
//                 Console.WriteLine("Please enter a real number!"); // catchall statement
//             }
//         }

//         // This function takes in the time spent charging and returns the total
//         // cost and points. The total cost is 1 + max(15, minutes) * 0.2. The points
//         // is floor(1.5 * max(minutes, 15)).
//         static (double cost, double points) CostAndPointsCalc(double minutes)
//         {
//             double finalTime = Math.Max(minutes, 15); // minimum 15 minutes charging time 
//             return (1.0 + finalTime * 0.2, Math.Floor(1.5 * finalTime));
//         } 


//         // main function of the program
//         static void Main(string[] args)
//         {
//             double minutesCharging = 0;
//             GetInput(ref minutesCharging, "Enter the number of minutes charging: ");

//             double totalCost, pointsGained; // declare two variable on the same line

//             // then I assign those variables to the result of the function
//             (totalCost, pointsGained) = CostAndPointsCalc(minutesCharging);

//             // Output the result formatted.
//             Console.WriteLine("{0} minutes of charging means £{1:.00} to pay, and {2} points gained ",
//             minutesCharging, totalCost, pointsGained);
//         }
//     }
// }