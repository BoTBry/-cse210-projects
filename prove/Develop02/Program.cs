using System;
using System.Net;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Myjournal phase01 = null; // Initialize as null to avoid issues later
        int answer = 0;

        while (answer != 4)
        {
            Console.WriteLine("Welcome to the journal program. \nPlease select one of the following choices: ");
            Console.WriteLine("1. Write \n2. Load \n3. Save \n4. Quit");
            answer = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("*****************************************");     
            Console.ForegroundColor = ConsoleColor.Gray;
            int write = 1;
            int load = 2;
            int save = 3;

            if (answer == write) // Write
            {
                phase01 = new Myjournal(); // Ensure it's initialized before use
                List<string> questions = new List<string>()
                {
                    "Who was the most interesting person you interacted with today?",
                    "What was the best part of your day?",
                    "How did you see the hand of the lord in your life today?",
                    "What was the strongest emotion you felt today?",
                    "If you had one thing you could do over today, what would it be?"
                };

                Random numGen = new Random();
                int number = numGen.Next(0, questions.Count);

                Console.WriteLine(questions[number]);
                phase01._entry01 = Console.ReadLine(); // Capture journal entry
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("*****************************************");  
                Console.ForegroundColor = ConsoleColor.Gray;

                DateTime currentTime = DateTime.Now;
                phase01._entry02 = currentTime.ToShortDateString(); // Save date
                phase01._entry03 = currentTime.ToShortTimeString(); // Save time

                // Display the entered journal information
                Console.WriteLine($"{phase01._entry01}\nDate: {phase01._entry02}, Time: {phase01._entry03}");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("----------------------------------------");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (answer == save) // Save
            {
                List<Myjournal> type = new List<Myjournal>();
                type.Add(phase01);

                phase01.SaveToFile(type);
            }
            else if (answer == load) // Load
            {
                try
                {
                    List<Myjournal> loadedJournals = phase01.ReadFromFile();
                    foreach (Myjournal journal in loadedJournals)
                    {
                        Console.WriteLine($"{journal._entry01} \nDate: {journal._entry02} Time: {journal._entry03}");
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File not found. Please check the file name.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while loading the file: {ex.Message}");
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("----------------------------------------");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}