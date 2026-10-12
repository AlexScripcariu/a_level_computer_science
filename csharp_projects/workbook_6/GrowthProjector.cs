//A program that can project the growth of a virus
// This is done by the model of: current * e^(rate * days)
using System;

namespace csharp_projects 
{
  class GrowthProjector
  {
    // A procedure to simulate how a virus grows with the number of days
    static void ModelVirus(int day, int currentCases, double R, int target)
    {
      long int populationInfected = currentCases;

      do 
      {
        populationInfected = Convert.ToInt64(currentCases * Math.Pow(2.718, (R * day)));
        Console.WriteLine("People infected on day {0}: {1}", day, populationInfected);
        day++;
      }
      while (populationInfected < target);

    }

    // Main function of the program
    static void Main(string[] args) 
    {
      // DAY 1, cases 1, R, 1.2, target 10000 people
      ModelVirus(1, 1, 1.2, 7800000000);
    }
  }
}
