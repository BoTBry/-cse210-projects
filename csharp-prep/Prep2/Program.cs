using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine();

        int A = 90;
        int B = 80;
        int C = 70;
        int D = 60;
        string letters = "";

        Console.Write("Hello, Please what was your score in the Exam?: ");
        string ans = Console.ReadLine();
        int Grade = int.Parse(ans);
        
        if (Grade >= A)
        {
            letters = "A";
        }
        else if (Grade >= B)
        {
            letters = "B";
        }
        else if (Grade >= C)
        {
            letters = "C";
        }
        else if (Grade >= D)
        {
            letters = "D";
        }
        else if (Grade < D)
        {
            letters = "F";
        }
        else
        {
            Console.WriteLine("Wrong Input, PLease try again");
        }

        Console.WriteLine($"Your grade is: {letters}");

        if (Grade >= C)
        {
            Console.WriteLine("Well done!!, You passed.");
        }
        else
        {
            Console.WriteLine("Sorry, But you failed.");
        }

    }
}