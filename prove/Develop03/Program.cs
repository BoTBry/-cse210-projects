using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine();

        Console.WriteLine("Kindly input the scripture: ");
        string scriptureName = Console.ReadLine();

        Console.WriteLine("Kindly input the chapter: ");
        int scriptureChapter = int.Parse(Console.ReadLine());

        Console.WriteLine("Kindly input the verse: ");
        int Verse = int.Parse(Console.ReadLine());

        Console.WriteLine("Kindly input the scripture verse: ");
        string scriptureVerse = Console.ReadLine();
        Console.WriteLine();


        Reference reference = new Reference(scriptureName, scriptureChapter, Verse);
        Scripture scripture = new Scripture(reference, scriptureVerse);
        //Word test = new Word("This is a verse");

        List<Scripture> scriptureList = new List<Scripture> { scripture };

        bool running = true;
        //Console.WriteLine(scripture.GetDisplayText());  // Display full scripture

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Try memorizing the scripture below: ");   
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "quit":
                    running = false;
                    Console.WriteLine("Thank you, Good bye!!");
                    break;
                case "":
                    scripture.HideRandomWords(3);  // Hide 3 words each time Enter is pressed
                    Console.Clear();  // Clear the console
                    Console.WriteLine(scripture.GetDisplayText());

                    if (scripture.IsCompletelyHidden())
                    {
                        Console.WriteLine("All words have been hidden.");
                        running = false;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input. Press enter or type 'quit'.");
                    break;
            }
        }
    }
}
