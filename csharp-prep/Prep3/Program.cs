using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine();

        Random ranGen = new Random();
        int number = ranGen.Next(1, 11);
        int attempts = 0;
        int guess = 0;
        while (guess != number)
        {            
            attempts++;
            Console.Write("Please pick a magic number from 1 - 10: ");
            guess = int.Parse(Console.ReadLine());
            if(guess == number)
            {
                Console.WriteLine($"Great!!, You guessed it, It took you {attempts}");
            }
            else if(guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if(guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }

        }

    }
}