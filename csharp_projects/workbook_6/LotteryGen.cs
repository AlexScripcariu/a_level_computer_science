// // A program that asks the user for 3 numbers, and then keep 'simulating'
// // spinning the lottery to see how many weeks it takes for them to win the 
// // large jackpot
// using System;

// namespace csharp_projects
// {
//     class LotteryGen
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
//                     if (result > 30)
//                     { // second limit check to make sure its a valid % decrease
//                         Console.WriteLine("Please enter a number between 1 to 30!");
//                         continue;
//                     }
//                     // This implies all 3 checks have passed
//                     return result;
//                 }
//                 Console.WriteLine("Please enter an integer!");
//             }
//         }

//         // This function generates 3 random numbers. Then they are matched with
//         // the user's numbers. If true, then return the number of attempts (in weeks)
//         // To obtain the lucky jackpot
//         static int SimulateLottery(int ball1, int ball2, int ball3)
//         {
//             int totalWeeks = 1;
//             Random option = new();

//             while (true)
//             { // This while loop keeps looping until all 3 balls match
//                 int genBall1 = option.Next(1, 31);
//                 int genBall2 = option.Next(1, 31);
//                 int genBall3 = option.Next(1, 31);
                
//                 if (ball1 == genBall1 && ball2 == genBall2 && ball3 == genBall3)
//                 { // This checks if the balls generated match the order of the input
//                     return totalWeeks;
//                 }

//                 totalWeeks++; // Increase the total number of weeks.    
//             }
//         }


//         // Main function of the program 
//         static void Main(string[] args)
//         {
//             int number1 = GetInput("Enter the first number (1-30): ");
//             int number2 = GetInput("Enter the second number (1-30): ");
//             int number3 = GetInput("Enter the third number (1-30): ");

//             int totalWeeks = SimulateLottery(number1, number2, number3);
//             int totalYears = Convert.ToInt32(totalWeeks * 7 / 365.25);

//             Console.WriteLine($"It took {totalWeeks} weeks to win the big jackpot! ({totalYears} years!)");    

//         }
//     }
// }