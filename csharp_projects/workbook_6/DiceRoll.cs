// Condition-controlled iterations
using System;

namespace csharp_projects 
{
    class DiceRoll
    {
        static int RollSix() 
        {
            Random dice = new Random();
            int roll = 0;
            int numberRolls = 0;

            while (roll != 1) // MODIFIED: stops when roll is 1. 
            {
                roll = dice.Next(1, 7);
                Console.WriteLine(roll); // MODIFIED: outputs the roll
                numberRolls++;
            }

            return numberRolls;
        }

        // Main program
        static void Main(string[] args) 
        {
            int result = RollSix();
            Console.WriteLine($"It took {result} rolls of a dice to roll a 1.");
        }
        
    }
}
