using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine();

        Reference reference = new Reference("either", 12, 4);
        Scripture scripture = new Scripture(reference, "This is a verse");
        Word test = new Word("This is a verse");

        List<Scripture> scriptureList = new List<Scripture>{scripture};

        bool running = true;
        Console.WriteLine(test.GetDisplayText());

        while(running)
        {
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

            switch(Console.ReadLine())
            {
                case "quit":
                    running = false;
                    Console.WriteLine("Thank you, Good bye!!");
                    break;
                default:
                    scripture.HideRandomWords(10);
                    Console.WriteLine(scripture.GetDisplayText());

                    if (scripture.IscomplrtrlyHidden())
                    {
                        running = false;
                    }
                    break;

            }
        }

    }
}