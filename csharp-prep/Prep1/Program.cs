using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine();

        Console.Write("What is your first name?: ");
        string FirstName = Console.ReadLine();

        Console.WriteLine();

        Console.Write("What is your second name? ");
        string SecondName = Console.ReadLine();
        
        Console.WriteLine();
        Console.WriteLine($"Your name is, {FirstName} {SecondName}.");
    }
}