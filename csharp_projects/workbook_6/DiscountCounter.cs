// // A program that displays the % off on a sale, going up rapidly
// using System;

// namespace csharp_projects
// {
//     class DiscountCounter
//     {
//         //A function that prompts a user with a given message
//         // It then tries to convert the input into a int. It will undergo type check,
//         // presence check, and limit checks
//         static int GetInput(string message)
//         {
//             string? userInput;
            
//             // validation loop
//             while (true)
//             {
//                 Console.Write(message);
//                 userInput = Console.ReadLine();
                
//                 if (string.IsNullOrEmpty(userInput)) 
//                 { // True if empty string, so fails presence check
//                     Console.WriteLine("Please enter a value!");
//                     continue;
//                 }

//                 if (Int32.TryParse(userInput, out int result))
//                 { // True if passes the type check
//                     if (result <= 0)
//                     { // This implies a failed limit check, must be +ve
//                         Console.WriteLine("Please enter a positive number!");
//                         continue;
//                     } 
//                     if (result > 100)
//                     { // second limit check to make sure its a valid % decrease
//                         Console.WriteLine("Please enter a number between 1 to 100!");
//                         continue;
//                     }
//                     // This implies all 3 checks have passed
//                     return result;
//                 }
//                 Console.WriteLine("Please enter an integer!");
//             }
//         }

//         // This function takes in some goal input and then displays a percentage
//         // that constantly increases until it gets up to that %
//         static void DisplayDiscount(int discount)
//         {
//             int currentDiscount = 0;
//             Random incr = new Random(); // (incr = incrementer)
            
//             // iterating until currentDiscount is discount
//             while (currentDiscount <= discount)
//             {
//                 Console.WriteLine($"{currentDiscount}%");
//                 currentDiscount += incr.Next(1, Math.Min(10, discount - currentDiscount) + 1);
//                 // By using the min above, this ensures discount never goes above the discount!
//             }
//         }


//         // Main function of the program
//         static void Main(string[] args)
//         {
//             int finalDiscount = GetInput("Enter the actual discount% : ");

//             // Output the discount to the user
//             Console.WriteLine("-----------");
//             DisplayDiscount(finalDiscount);
//         }
//     }
// }