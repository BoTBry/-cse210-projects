// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Develop05 World!");
//     }
// }
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Develop03 World!");
//         Console.WriteLine();

//         Reference reference = new Reference("either", 12, 4);
//         Scripture scripture = new Scripture(reference, "This is a verse");
//         Word test = new Word("This is a verse");

//         List<Scripture> scriptureList = new List<Scripture>{scripture};

//         bool running = true;
//         Console.WriteLine(test.GetDisplayText());

//         while(running)
//         {
//             Console.WriteLine();
//             Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

//             switch(Console.ReadLine())
//             {
//                 case "quit":
//                     running = false;
//                     Console.WriteLine("Thank you, Good bye!!");
//                     break;
//                 default:
//                     scripture.HideRandomWords(10);
//                     Console.WriteLine(scripture.GetDisplayText());

//                     if (scripture.IscomplrtrlyHidden())
//                     {
//                         running = false;
//                     }
//                     break;

//             }
//         }

//     }
// }

// using System;
// using System.Net;
// using System.Collections.Generic;

// class Scripture
// {
//     private Reference _Reference;
//     private List<Word> _words = new List<Word>();

//     public Scripture(Reference reference, string text)
//     {
//         string[] split = text.Split(" ");
//         _Reference = reference;
//         foreach (var words in split)
//         {
//             _words.Add(new Word(words));

//         }
//     }

//     public void HideRandomWords(int numberToHide)
//     {
//         Random randomNum = new Random();

//         int hidden = 0;
//         while(hidden < numberToHide)
//         {

//         int counter = randomNum.Next(0, _words.Count);
//         if(!_words[counter].IsHidden())
//         {
//             _words[counter].Hide();
//             hidden++;
//         }
//         else
//         {
//             _words[counter].Show();
//         }

//         }
//     }
    
//     public string GetDisplayText()
//     {
//         return "hello world";
//     }

//     public bool IscomplrtrlyHidden()
//     {
//         return false;
//     }
// }


// using System;
// using System.Net;
// using System.Collections.Generic;

// class Word
// {
//     private String _text;
//     private bool _isHidden = false;

//     public Word(String text)
//     {
//         _text = text;
//         _isHidden = false;
//     }

//     public void Hide()
//     {
//         _isHidden = true;
//     }

//     public void Show()
//     {
//         _isHidden = false;
//     }

//     public bool IsHidden()
//     {
//         return _isHidden;
//     }

//     public String GetDisplayText()
//     {
//         if (IsHidden())
//         {

//             return "";

//         }
//         else
//         {
//             return _text;
//         }
//     }
// }


// using System;
// using System.Net;
// using System.Collections.Generic;

// class Reference
// {
//     private String _book;
//     private int _chapter;
//     private int _verse;
//     private int _endverse;

//     public Reference(String book, int chapter, int verse )
//     {
//         _book = book;
//         _chapter = chapter;
//         _verse = verse;
//     }

//     public Reference(String book, int chapter, int Startverse, int endverse)
//     {
//         _book = book;
//         _chapter = chapter;
//         _endverse = endverse;

//     }

//     // public String GetDisplayText()
//     // {

//     // }
// }
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine();

        Reference reference = new Reference("Ether", 12, 4);
        Scripture scripture = new Scripture(reference, "This is a verse that will be progressively hidden.");
        Word test = new Word("This is a verse");

        List<Scripture> scriptureList = new List<Scripture> { scripture };

        bool running = true;
        Console.WriteLine(scripture.GetDisplayText());  // Display full scripture

        while (running)
        {
            Console.WriteLine();
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

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] splitText = text.Split(' ');

        foreach (var word in splitText)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hidden = 0;

        while (hidden < numberToHide && !IsCompletelyHidden())
        {
            int index = random.Next(0, _words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (var word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return string.Join(" ", displayWords);
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? "____" : _text;
    }
}

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Optional: Add a method to display the reference (book, chapter, verse).
}
