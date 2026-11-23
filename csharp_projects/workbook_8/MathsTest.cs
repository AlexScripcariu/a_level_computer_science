// // This program generates a maths test for children
// // It will keep taking in children to test until it breaks
// using System;

// namespace csharp_projects
// {
//     class MathsTest
//     {
//         static int[,] questions = new int[5, 2];

//         // This hard-coded procedure abstracts the questions to ask
//         // [operand 1, operand 2] each operand will be added
//         static void GenerateQuestions()
//         {
//             questions[0, 0] = 1;
//             questions[0, 1] = 1;
//             questions[1, 0] = 5;
//             questions[1, 1] = 10;
//             questions[2, 0] = 6;
//             questions[2, 1] = 6;
//             questions[3, 0] = 7;
//             questions[3, 1] = 7;
//             questions[4, 0] = 3;
//             questions[4, 1] = 8;
//         }

//         // This function asks the user the 5 maths questions and returns the number they got correct
//         static int AskQuestions()
//         {
//             int score = 0;
            
//             // iterate through all 5 questions
//             for (int i = 0; i < 5; i++)
//             {
//                 // Ask the question
//                 Console.WriteLine();
//                 int userResponse = Input.GetInput($"What is: {questions[i, 0]} + {questions[i, 1]}?: ", 1);
//                 if (userResponse == questions[i, 0] + questions[i, 1])
//                 {   // This implies correct answer
//                     Console.WriteLine("Correct!");
//                     score++;
//                 } else
//                 {   //incorrect answer
//                     Console.WriteLine("Incorrect.");
//                 }
//             }

//             return score;
//         }

//         // This procedure keeps inputting children and testing them
//         // Then outputting the score
//         static void StartTest()
//         {
//             while (true)
//             {
//                 string childName = Input.GetStrInput("What is your name?(n to quit): ").ToLower();
//                 if (childName == "n")
//                 { // n means to stop iterating through children
//                     break;
//                 }

//                 // Get the user score by asking them the 5 questions
//                 int totalScore = AskQuestions();
                
//                 // Output score
//                 Console.WriteLine($"{childName}, you got {totalScore}/5!");
//             }
//         }


//         // Main function of the program 
//         static void Main(string[] args)
//         {
//             // Get questions
//             GenerateQuestions();

//             StartTest();
//         }
//     }
// }