// // A program that calculates how much a person has to pay a car park area
// using System;

// namespace csharp_projects
// {
//     class CarPark
//     {
//         // This function takes in an input and checks if the format matches
//         // the time intervall hh::mm, returning the hour and minutes if it does
//         static (int, int) GetTime()
//         {
//             string time;
//             // format checks
//             while (true)
//             {
//                 time = Input.GetStrInput("Enter the time (hh:mm): ");

//                 if (time.Length != 5)
//                 {
//                     Console.WriteLine("Invalid length.");
//                     continue;
//                 }

//                 if (Int32.TryParse(time.Substring(0, 2), out int hour))
//                 {   // type check
//                     if (!(0 <= hour && hour <= 23))
//                     {
//                         Console.WriteLine("Must be a valid hour range (0-23)!");
//                         continue;
//                     }
//                 } 
//                 else
//                 {
//                     Console.WriteLine("Hours must be an integer 0-23!");
//                     continue;
//                 }
                
//                 if (Int32.TryParse(time.Substring(3, 2), out int minutes))
//                 {   // type check
//                     if (!(0 <= minutes && minutes <= 59))
//                     {
//                         Console.WriteLine("Must be a valid minute range (0-59)!");
//                         continue;
//                     }
//                 } 
//                 else
//                 {
//                     Console.WriteLine("Minutes must be an integer 0-59!");
//                     continue;
//                 }

//                 if (time[2] != ':')
//                 {
//                     Console.WriteLine("Time values must be separated by a :");
//                     continue;
//                 }

//                 // Valid time, so return hour and minutes
//                 return (hour, minutes);
//             }
//         }

//         // This function returns the total cost of parking for a time interval
//         static double CalculateParkCost(bool blueCard)
//         {
//             (int startH, int startM) = GetTime();
//             (int endH, int endM) = GetTime();
            
//             int startTMins = startH * 60 + startM; // times represented in minutes
//             int endTMins = endH * 60 + endM; 
//             // Calculate if overnight or not
//             int totalM = endTMins - startTMins;
            
//             int gapH = totalM / 60; // gets the hours by integer div. of 60
//             int gapM = totalM % 60; // gets the minutes by moduloing 60
//             if (startTMins > endTMins)
//             {
//                 // add on A day worth of minutes
//                 totalM += 24 * 60;
//                 gapH = totalM / 60;
//                 gapM = totalM % 60;

//                 // subtract from Midnight to 8pm
//                 totalM -= Math.Min(240, 24 * 60 - startTMins);
//                 // subtract from 6am to midnight
//                 totalM -= Math.Min(360, endTMins);
//             } else if (endH >= 20)
//             { // this implies some overlap between 8PM to midnight. 
//                 totalM -= endTMins - (20 * 60) + Math.Max(0, startTMins - 20 * 60);
//             } else if (startH < 6)
//             {
//                 totalM -= 6 * 60 - startTMins - Math.Max(6 * 60 - endTMins, 0);
//             }

//             // Given the above math, the totalM should now represent the total 
//             // minutes that are paid car parking
//             // Consider disabled users
//             if (blueCard) totalM -= 180;
//             //Console.WriteLine($"TOTAL TIME: {totalM}");
//             if (totalM <= 0) // no time spent -> free
//             {
//                 return 0;
//             }
//             else if (totalM <= 60)
//             { // pay 1.50
//                 return 1.50;
//             }
//              else if (totalM <= 120)
//             {
//                 return 2.90;
//             } 
//             else if (totalM <= 180)
//             {
//                 return 3.90;
//             } 
//             else if (totalM <= 240)
//             {
//                 return 4.50;
            
//             } else
//             {
//                 return 8.00; 
//             }
//         }
//         // Main function of the program
//         static void Main(string[] args) 
//         {
//             double cost = CalculateParkCost(false);
        
//             // Output result to console
//             Console.WriteLine("The total cost of parking is £{0:0.00}.", cost);
//         }
//     }
// }
