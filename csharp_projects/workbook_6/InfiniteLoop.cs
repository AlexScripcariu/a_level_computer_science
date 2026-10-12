// A program that outputs a message in an infinite loop
using System;

namespace csharp_projects
{
    class InfiniteLoop 
    {
        // A program that outputs "To infinity and beyond" in an inf. loop
        static int ToInfinity() 
        {
            while (true)
            {
                Console.WriteLine("To infinity and beyond...");
            }
        }
        
        // Main program
        static void Main(string[] args) 
        {
          ToInfinity();
        }
    }
}
