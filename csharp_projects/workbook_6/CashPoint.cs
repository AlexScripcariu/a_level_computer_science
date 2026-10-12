// // A program that takes in some amount of money (a multiple of 5) and begins to withdraw
// // That money in the least amount of notes of £20, £10, and £5
// using System;

// namespace csharp_projects
// {
//     class CashPoint
//     {
//         // A procedure that displays how an ATM would dispense money to a customer
//         // It can only dispense £20, £10, and £5. As each one is a multiple of another
//         // This makes the problem a classic greedy problem (coin-sum) and not DP problem
//         static void DisplayWithdraw(int amount)
//         {
//             Console.WriteLine($"Withdraw: £{amount}.");
//             // keep withdrawing money until all has been withdrawn
//             while (amount > 0)
//             {
//                 if (amount >= 20)
//                 { // This means we can withdraw £20 and not be negative
//                     Console.WriteLine("Dispense £20.");
//                     amount -= 20; // decrease by 20
//                 }
//                 else if (amount >= 10)
//                 { // This means we can withdraw £10 and not be negative
//                     Console.WriteLine("Dispense £10.");
//                     amount -= 10;
//                 } 
//                 else
//                 { // base-case: Can only get rid of £5
//                     Console.WriteLine("Dispense £5.");
//                     amount -= 5;
//                 }
//             }
//         }
        
//         // Main function of the program
//         static void Main(string[] args)
//         {
//             // Take in user variable
//             int toWithdraw = Input.GetInput("Enter the amount to withdraw: ");

//             // Output to console
//             DisplayWithdraw(toWithdraw);
//         }
//     }
// }

