using System;

class Program
{
    static void Main(string[] args)
    {
        HelloWorld();
        DisplayWelcome();

        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();

        int Square = SquareNumber(UserNumber);
        DisplayNameNumber(UserName, Square);
    }
    static void HelloWorld()
    {
        Console.WriteLine("Hello Prep5 World!");
        Console.WriteLine();
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name?: ");
        string UserName = Console.ReadLine();
        return UserName;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number?: ");
        int UserNumber = int.Parse(Console.ReadLine());
        return UserNumber;
    }
    static int SquareNumber(int UserNumber)
    {
        int Square = UserNumber * UserNumber;
        return Square;
    }
    static void DisplayNameNumber(string UserName, int Square)
    {
        Console.WriteLine($"Welcome to the program! {UserName}, Your favorite number squared is: {Square} ");
    }
        
    
}