// // A program that outputs which hoppers to take in food from
// // for a given meal and the number of meals to make
// using System;

// namespace csharp_projects
// {
//     class AutomaticFeeder
//     {
//         // This function keeps taking in user input
//         // until it matches one of 3 meals: breakfast, lunch or dinner
//         // Then it returns the meal type
//         static string GetMeal()
//         {
//             string userMeal;

//             while (true)
//             { // keep looping until valid meal
//                 userMeal = Input.GetStrInput("Enter the meal: ").ToLower();

//                 if (userMeal != "lunch" && userMeal != "dinner" && userMeal != "breakfast")
//                 {
//                     Console.WriteLine("Please enter: breakfast, lunch or dinner.");
//                 } else
//                 {
//                     return userMeal;
//                 }
//             }
//         }

//         // This procedure prints out which hoppers to get food from
//         // depending on the meal and quantity
//         static void OutputHoppers(string meal, int quantity)
//         {
//             for (int i = 0; i < quantity; i++)
//             { // loop quantity times to output enough food
//                 if (meal == "breakfast" || meal == "dinner")
//                 { // breakfast or dinner req. hopper 1
//                     Console.WriteLine("Hopper 1");
//                 }
//                 if (meal == "lunch" || meal == "dinner")
//                 { // lunch or dinner req. hopper 2
//                     Console.WriteLine("Hopper 2");
//                 }
//             }
//         }
        


//         // Main function of the program
//         static void Main(string[] args) 
//         {
//             string meal = GetMeal(); // gets the meal type
//             int quantity = Input.GetInput("Enter the quantity: ", 1, 10);

//             OutputHoppers(meal, quantity);

//         }
//     }
// }
