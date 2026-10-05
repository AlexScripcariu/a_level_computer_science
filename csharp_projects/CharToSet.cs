// A program that takes in a letter (1-26) and ' ' (space) and outputs its ASCII
// and EBCDIC values. For ascii, we can do this easily, but for EBCDIC, a formula is needed.
using System;

namespace csharp_projects
{
    class CharToSet
    {
        // A function that prompts a user for an input given a message
        // It will undergo many checks: length, presence, value so its alphabetical or ' '
        // Then if the letter passes all checks, its returned uppercase
        static char GetInput(string message)
        {
            string userInput;

            // input validation
            while (true)
            {
                Console.Write(message);
                userInput = Console.ReadLine() ?? "";

                if (string.IsNullOrEmpty(userInput))
                { // presence check
                    Console.WriteLine("Please enter a value!");
                    continue;
                } 
                else if (userInput.Length != 1)
                { // length check
                    Console.WriteLine("The maximum length is 1! not {0}", userInput.Length);
                    continue;
                }

                // This stores the lower case first character
                char firstChar = Convert.ToChar(Convert.ToString(userInput[0]).ToUpper());
                
                if (firstChar == ' ' || (0 <= firstChar - 'A' && firstChar - 'A' <= 26))
                { // this implies its a ' ' or its between a-z. Value/format check 
                    return firstChar;
                }
                
                Console.WriteLine("The input must be alphabetical or a space!");
            }
        }

        // a function that takes in a single alphabetical character (or space) and
        // converts it to its ASCII and EBCDIC format. 
        static (int, int) ConvertLetter(char letter)
        {
            // check to see if its not a space:
            if (letter == ' ')
            {
                return (32, 64);
            }

            int toASCII = letter; // this converts the letter into its ASCII value automatically
            
            // THE MATH BEHIND EBCDIC:
            // each block of 9 increases by 16 then 16 + 1 and so on.
            // for this instance, we can just see if the number is bigger than 18 by n / 18.
            // if true, then n / 18 == 1 so we can just add this on.
            // Let tAS be the ascii value of the letter. 
            // So the 'starting value' of each block is (tAS - 'a') / 9 * 16 + 193.
            // Then we add on (tAS - 'a') % 9 (the offset from the starting block)
            
            int asciiOffset = toASCII - 'A';

            int toEBCDIC = (asciiOffset) / 9 * 16 + 193 + ((asciiOffset) % 9) + asciiOffset / 18;

            return (toASCII, toEBCDIC);
        }

        // Main function of the program 
        static void Main(string[] args)
        {
            char letter = GetInput("Please enter a letter: ");


            // get the new converted values
            (int letterASCII, int letterEBCDIC) = ConvertLetter(letter);

            // output the result
            Console.WriteLine("'{0}' to ASCII is {1} and to EBCDIC is {2}", letter, letterASCII, letterEBCDIC);
        }
    }
}