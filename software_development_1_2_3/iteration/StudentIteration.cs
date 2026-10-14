using System;
using System.Diagnostics.Metrics;

class Program
{
    /*
     * For loops
     */
    static void ForTwoTimesTable()
    {
		for (int i = 1; i <= 12; i++)
		{
			int sum = 2 * i;
			Console.WriteLine($"2 x {i} = {sum}");
		}
    }

    static void ForTimesTables()
    {
        // Enter code to output times tables from 1 to 12 using nested for loops
        for (int i = 1; i <= 12; i++)
        {
            for (int j = 1; j <= 12; j++)
            {
                int sum = i * j;
                Console.WriteLine($"{i} * {j} = {sum}");
            }
        }
    }

    static void EvenNumbers()
    {
        // Enter code to output all even numbers from 1 to 100 using a for loop and %
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    /*
     * While loops
     */
    static void WhileTwoTimesTable()
    {
        // Enter code to output the 2 times table using a while loop
        int counter = 1;
        while (counter <= 12)
        {
            Console.WriteLine($"2 * {counter} = {2 * counter}");
            counter++;
        }
    }

    static void WhileTimesTables()
    {
        // Enter code to output times tables from 1 to 12 using nested while loops
        int counterI = 1;
        while (counterI <= 12)
        {
            int counterJ = 1;
            while (counterJ <= 12)
            {
                int sum = counterI * counterJ;
                Console.WriteLine($"{counterI} * {counterJ} = {sum}");
                counterJ++;
            }
            counterI++;
        }
    }

    static void OddNumbers()
    {
        // Enter code to output all odd numbers from 1 to 100 using a while loop and %
        int currentNumber = 1;
        while (currentNumber <= 100)
        {
            if (currentNumber % 2 == 0)
            {
                Console.WriteLine(currentNumber);
            }
            currentNumber++;
        }
    }

    /*
     * Iteration problems
     */
    static int CityPopulation()
    {
        // Enter code to calculate how many years until one city overtakes another
		double gonbust = 100000;
		double nuplace = 30000;
		int years = 0;

        while (gonbust >= nuplace)
        {
            gonbust *= 0.92;
            nuplace *= 1.07;
        }

        Console.WriteLine("Years until nuplace has a larger population: {0}", years);

        return 0; // placeholder
    }

    static void RepeatedSubtraction()
    {
        // Enter code to repeatedly subtract one number from another
        // Print the result rather than return it
        int a = 25;
        int b = 3;
        int quotient = 0;
        int remainder = 0;

        while (a >= b)
        {
            a -= b;
            quotient++;
        }
        Console.WriteLine($"{a} / {b} = {quotient} remainder {remainder}");
    }

    static void FarmersFences()
    {
        // Enter code to calculate number of fence posts needed
        // Print the result rather than return it
        for (int i = 1; i <= 49; i++)
        {
            Console.WriteLine($"Option: {i}, {i}, {100 - 2 * i}, {100 - 2 * i}");
        }
    }

    static void MaximisingProfits()
    {
        // Enter code to calculate how many years until a profit target is reached
        // Print the result rather than return it
        for (int i = 0; i <= 6; i ++)
        {
            int price = 35 + i * 5;
            int profit = (price - 20) * (200 - 25 * i);
            Console.WriteLine($"Selling chocolate at {price}p results in a profit of {profit}p");
        }
    }

    static void Main()
    {
        // Call whichever method you want to test
        ForTwoTimesTable();
    }
}
