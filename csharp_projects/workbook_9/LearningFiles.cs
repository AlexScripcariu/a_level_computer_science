// // Files and exceptions
// using System;
// using System.IO;

// namespace csharp_projects
// {
//     class LearningFiles
//     {
//         // Subroutine to write data to a text file
//         static void WriteData()
//         {
//             string fileName = "program_data.txt";
//             TextWriter textFile = new StreamWriter(fileName);
//             textFile.WriteLine("This is my first line of data."); 
//             textFile.WriteLine("This is my second line");
//             textFile.WriteLine("This is the third line.");
//             textFile.Close();
//         }

//         //Subroutine to read all data from a text file
//         static void ReadData()
//         {
//             string fileName = "program data.txt";
//             try
//             {
//                 TextReader textFile = new StreamReader(fileName);
//                 string data;

//                 while ((data = textFile.ReadLine()) != null)
//                 { // output the line of data as long as the data is not null
//                     Console.WriteLine(data);
//                 }
//                 textFile.Close();
                
//             }
//             catch
//             {
//                 Console.WriteLine("File name not found!: {0}", fileName);
//             }

//         }
//         // Main function of the program
//         static void Main(string[] args)
//         {
//             ReadData();
//         }
//     }
// }