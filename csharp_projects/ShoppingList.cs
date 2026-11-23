// Shopping list problem, representing CRUD operations
using System;
using System.IO;
using System.Collections.Generic;


namespace csharp_projects
{
    class ShoppingList
    {
        static string[] menuOptions = {"Create new List", "Add to list", "Delete item", "Output list"};
        static List<string> listNames = new();
        static List<List<string>> listItems = new();
        const string FOLDER = "shoppingLists/";

        // This is more of a wrapper function that allows you to add separators to text for clarity
        static void Sep()
        {
            Console.WriteLine("-----------");
        }

        // procedure that stores all the shopping list names
        static void LoadLists(string filePath)
        {
            // load in the path stored in the folder
            string path = filePath + "meta_list.txt";

            TextReader textFile = new StreamReader(path);

            string? line;

            // go through each line, each line stores the list name
            while ((line = textFile.ReadLine()) != null)
            {
                listNames.Add(line);
                listItems.Add([]);
            }
            textFile.Close();
        }
        
        // procedure that reads in all the data from the shopping lists
        static void ReadListsInitial(string filePath)
        {
            int listSize = listNames.Count;

            for (int i = 0; i < listSize; i++)
            { // go through each file and read in the contents into a list
                string path = filePath + listNames[i] + ".txt";
                TextReader textFile = new StreamReader(path);
                string? line;
                while ((line = textFile.ReadLine()) != null)
                {
                    listItems[i].Add(line);
                }
                textFile.Close();
            }
        }

        // This function updates meta_list.txt to contain the list of all items
        static void AddMetaList()
        {
            string path = FOLDER + "meta_list.txt";
            File.WriteAllText(path, "");
            TextWriter textFile = new StreamWriter(path);

            for (int i = 0; i < listNames.Count; i++)
            {
                textFile.WriteLine(listNames[i]);
            }
            textFile.Close();
        }

        // this procedure reads in all the Lists and then updates the files. 
        // Done at the end or if a 'save' is called.
        static void SaveLists(string filePath)
        { 
            AddMetaList();


            int listSize = listNames.Count;

            for (int i = 0; i < listSize; i++)
            {
                string path = filePath + listNames[i] + ".txt";
                File.WriteAllText(path, "");
                TextWriter textFile = new StreamWriter(path);
                // go through each item in each list and write it to the file.
                int sizeI = listItems[i].Count;
                // Debug line for outputting lists
                //Console.WriteLine("LIST: {0}, SIZE: {1}", listNames[i], listItems[i].Count);
                for (int j = 0; j < sizeI; j++)
                {
                    textFile.WriteLine(listItems[i][j]);
                }
                textFile.Close();
            }
        }


        // This procedure determines which shopping list to pick and then display the
        // contents of its list.
        static void DisplayShoppingList(int listID)
        {
            Sep();
            if (listID == -1) return;
            for (int i = 0; i < listItems[listID].Count; i++)
            { // go through each item in the list
                Console.WriteLine($"{i + 1}: {listItems[listID][i]}");
            }
            Sep();
        }

        // This function displays the options for the user to pick. 
        // Keeps doing this until its a quit, or a valid option is picked.
        // If quit -1 is returned
        static int UserChoice()
        {
            Console.WriteLine("Select an option: ");
            string option;
            while (true)
            {
                // Display options, with numbering.
                int n = menuOptions.Length;
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"{i}: {menuOptions[i - 1]}");
                }
                Sep();
                option = Input.GetStrInput("Enter the option. (Or n to quit): ").ToLower();
                if (option == "n") return -1;
                // determine if the option is valid;
                try
                {
                    int result = Int32.Parse(option);
                    if (result <= 0 || result > n)
                    { // valid data type, but value out of range.
                        Console.WriteLine("Please enter a number between 1->{0}", n);
                        continue;
                    }
                    return result;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter an integer!");
                    continue;
                }
            }
            
        }

        // This procedure creates a new list that will be stored in the data
        static void CreateNewList()
        {
            string newListName;
            while (true)
            {
                newListName = Input.GetStrInput("What do you want to call your new list? (n to quit): ");
                if (newListName.ToLower() == "n") return;
                string confirm = Input.GetStrInput("Are you sure (Y/y to confirm): ").ToLower();
                if (confirm == "y")
                {
                    bool valid = true; // flag variable to check duplicity.
                    for (int i = 0; i < listNames.Count; i++)
                    {
                        if (listNames[i] == newListName)
                        {// Determine if that list already exists. 
                            Console.WriteLine("This file already exists! Try again.");
                            valid = false;
                            break;
                        }
                    }
                    if (valid) break;
                }
    
            }
            // all checks passed, so create the new list

            listNames.Add(newListName);
            newListName += ".txt";
            File.Create(FOLDER + newListName).Close();
            listItems.Add([]);
            // output success message
            Console.WriteLine("Created {0} successfully!", newListName);
        }


        // Helper function that returns the index of the list wanted to be targeted
        // Returns -1 if the user backs out
        static int PickList()
        {
            while (true)
            {
                // Go through each list and ask the user to pick a list number
                int totalLists = listNames.Count;
                Console.WriteLine("---LISTS---");
                for (int i = 0; i < totalLists; i++)
                {
                    Console.WriteLine($"{i + 1}: {listNames[i]}");
                }
                Sep();
                int option = Input.GetInput("Enter a list number, or 0 to go back: ", 0, totalLists);
                return option - 1; // this gets the indexing back to 0-indexed
            }
        }

        // This procedure takes in a list index, and then adds a new item to the end of the list
        static void AddItemsToList()
        {
            int listID = PickList();
            if (listID == -1) return; // user aborted operation

            while (true)
            {
                string itemToAdd = Input.GetStrInput("Enter the item to add (n to quit): ");
                if (itemToAdd.ToLower() == "n") return;
                string confirm = Input.GetStrInput("Type in Y/y to confirm addition: ").ToLower();
                if (confirm == "y")
                { // add the item to the list
                    listItems[listID].Add(itemToAdd);
                    Console.WriteLine("{0} added!", itemToAdd);
                }
            }
        }

        // This procedure determines a list to remove items from, then asks the user to type
        // in an item to remove from the list. If found, the item will be removed, after confirmation.
        static void RemoveItemsFromList()
        {
            int listID = PickList();
            if (listID == -1) return;

            // Display the list
            Console.WriteLine("---List Content---");
            DisplayShoppingList(listID);

            while (true)
            {
                string itemToRemove = Input.GetStrInput("Type in the item you want to remove (-1 to stop): ");
                if (itemToRemove == "-1") return;
                string confirm = Input.GetStrInput("If found, this item will be removed. Confirm (Y/y)?: ").ToLower();
                if (confirm == "y")
                {
                    if (listItems[listID].Remove(itemToRemove))
                    {
                        Console.WriteLine($"{itemToRemove} found and removed!");
                    } else
                    {
                        Console.WriteLine("Item not found. Deletion unsuccessfull.");
                    }
                }
            }
        }

        // This function is responsible for being the main function that controls
        // The control flow of the program. It takes in the user choice and then
        // performs one of the 4 necessary operations
        static void ShoppingMenu()
        {

            while (true)
            {
                // display the options
                int choice = UserChoice();
                

                // use a switch for each item for readability.
                switch (choice)
                {
                    case 1:
                        // Create the new list
                        CreateNewList();
                        break;
                    case 2:
                        // Add some items to an existing list
                        AddItemsToList();
                        break;
                    case 3:
                        // remove certain items from a list
                        RemoveItemsFromList();
                        break;
                    case 4:
                        DisplayShoppingList(PickList());
                        break;
                    default:
                        return;
                }
            }
        }


        // Main function of the program
        static void Main(string[] args)
        {
            
            LoadLists(FOLDER);
            ReadListsInitial(FOLDER);
            // Function to determine which option
            ShoppingMenu();
            SaveLists(FOLDER);
        }
    }
}