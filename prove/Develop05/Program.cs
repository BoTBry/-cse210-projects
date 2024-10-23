using System;
using System.Collections.Generic;
using System.Threading;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}: {_description}");
        Console.WriteLine("Please enter the duration in seconds:");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000);  // Pause for 3 seconds
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Good job! You've completed the {_name} activity for {_duration} seconds.");
        Thread.Sleep(2000);  // Pause for 2 seconds
    }

    protected void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public virtual void Run()
    {
        DisplayStartingMessage();
        DisplayEndingMessage();
    }
}

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void Run()
    {
        base.Run();
        for (int i = 0; i < _duration / 6; i++)  // Repeat based on the duration
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);  // 3 seconds for inhale
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);  // 3 seconds for exhale
        }
    }
}

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who are the people that you have helped this week?",
        "What are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on positive things by having you list as many as you can.") { }

    public override void Run()
    {
        base.Run();
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);

        List<string> userList = GetListFromUser();
        Console.WriteLine($"You listed {userList.Count} items.");
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Enter an item:");
            string item = Console.ReadLine();
            items.Add(item);
        }

        return items;
    }
}

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?"
    };

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times when you have shown strength and resilience.") { }

    public override void Run()
    {
        base.Run();
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);

        foreach (var question in _questions)
        {
            Console.WriteLine(question);
            ShowSpinner(3);  // Pause for reflection
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                case 2:
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                case 3:
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;
                case 4:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    break;
            }
        }
    }
}
