// // A program that models how compound interest acts in a bank account
// using System;

// namespace csharp_projects
// {
//     class CompoundInterest
//     {
//         // Procedure to output the interest growth on a balance
//         static void Compound(double balance, double interestRate, double targetBalance)
//         {
//             int year = 1;
//             double interest;

//             // Iterate until the balance matches the target balance
//             while (balance < targetBalance)
//             {
//                 interest = balance * interestRate;
//                 balance += interest;
//                 Console.WriteLine($"Year {year}: New Balance = £{balance:0.00}");
//                 year++;
//             }
//         }
                
        
//         // Main function of the program 
//         static void Main(string[] args)
//         {
//             //      start, growth, target
//             Compound(100, 0.04, 200);
//         }
//     }
// }
