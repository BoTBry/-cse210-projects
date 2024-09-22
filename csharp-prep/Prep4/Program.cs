using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine();

        int stop = 0;
        int input = 1;
        List<int> numbers = new List<int>();

        while(input != stop)
        {            
            Console.Write("Please input a number to be added: ");
            string input2 = Console.ReadLine();
            input = int.Parse(input2);

            if(input != stop)
            {
                numbers.Add(input);
            }
        }
        int sum = 0;
        foreach (int item in numbers)
        {
            sum = sum + item;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The Average is: {average}");

        int max = numbers[0];
        foreach(int i in numbers)
        {
            if(i > max)
            {
                max = i;
            }
        }
        Console.WriteLine($"The max is: {max}");

    }
}