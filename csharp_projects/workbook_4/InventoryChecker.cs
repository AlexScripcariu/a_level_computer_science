// // A program that gets in multiple items to add to an inventory
// // Then it checks to see if an item is in the inventory, this done
// // by the function 'Exists'
// using System;

// namespace csharp_projects
// {
//     class InventoryChecker
//     {   
//         // This function prompts a user to input a string
//         // given some message. If it passes a presence check,
//         // then the value is returned.
//         static string GetInput(string message)
//         {
//             string? userInput;

//             // validation (only presence!)
//             while (true)
//             {
//                 Console.Write(message);
//                 userInput = Console.ReadLine();

//                 if (!string.IsNullOrEmpty(userInput))
//                 { // this would imply the check has passed
//                     return userInput; // return back to user
//                 }
//                 // only outputted if failed check
//                 Console.WriteLine("Please enter a value!");
//             }
//         }


//         // This is a function that allows a user to input their inventory
//         // Then it stores their items into a strings, with ',' determiners
//         static string InputInventory()
//         {
//             string userInventory = "";
//             bool done = false;
            
//             // keep looping to add items to the inventory
//             while (!done)
//             {
//                 userInventory += GetInput("Enter an item to add to the inventory: ") + ",";

//                 // prompt the user to keep asking for another item
//                 Console.Write("Type in Y to continue, anything else to exit: ");

//                 if (Console.ReadLine() != "Y")
//                 {
//                     done = true;
//                 } 
//             }

//             // Once the user has inputted their inventory, output from [0, len-1)
//             // This is so the final item is ignored
//             return userInventory[..^1];
//         }

//         // This function takes in an inventory (str) and an item to find (str)
//         // Then it determines if the item is in the inventory, if so the return true
//         static bool Exists(string inventory, string item)
//         {
//             // stringX.Contains(Y) is only true when the ITEM IS FOUND!
//             // this matches our result (either to return true/false)
//             return inventory.Contains(item);  
//         }


//         // Main function of the program
//         static void Main(string[] args)
//         {
//             // This assumes the inventory is in the form of:
//             // item1,item2,item3,...,itemn
//             string inventory = InputInventory();
//             string itemToFind = GetInput("Enter the item to find: ");
            
//             // determine if we can find that item
            
//             if (Exists(inventory, itemToFind))
//             {
//                 Console.WriteLine("{0} is in the inventory!", itemToFind);
//             } 
//             else
//             {
//                 Console.WriteLine("{0} is not in the inventory", itemToFind);
//             }
//         }
//     }
// }