using System;
using System.Collections.Generic;

class Video
{
    private string title;
    private string authortitle;
    private int length;

    public void Tracker(string _title, string _authortitle, int _length)
    {
        title = _title;
        authortitle = _authortitle;
        length = _length;
        Console.WriteLine($"Title: {title} \nAuthor Title: {authortitle} \nLength: {length}S");
    }
    
    public void video01()
    {
        Console.WriteLine("Hello Foundation1 World!");
        Console.WriteLine();

        Video _video = new Video();
        _video.Tracker("How To Cook", "The BoT_Bryan", 1300);
        Console.WriteLine();

        Comments _comments = new Comments();

        _comments.Comment("Bryan", "I really love it");
        _comments.Comment("Joy", "Great video");
        _comments.Comment("Tobi", "Do better!!");
        _comments.DisplayNumComments();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("----------------------------------------");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    public void video02()
    {
        Console.WriteLine("Hello Foundation1 World!");
        Console.WriteLine();

        Video _video = new Video();
        _video.Tracker("How To Eat", "The Eater 3000", 800);
        Console.WriteLine();

        Comments _comments = new Comments();

        _comments.Comment("Wizard", "lose weight please TT");
        _comments.Comment("Her sister", "She eats all our food!!");
        _comments.Comment("FBI", "We got her");
        _comments.DisplayNumComments();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("----------------------------------------");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    public void video03()
    {
        Console.WriteLine("Hello Foundation1 World!");
        Console.WriteLine();

        Video _video = new Video();
        _video.Tracker("ICT Is The Best Strategy", "The BoT_Bryan", 11300);
        Console.WriteLine();

        Comments _comments = new Comments();

        _comments.Comment("Astro", "Cap!!");
        _comments.Comment("TrustSamii", "Yes, ICT is the best");
        _comments.Comment("B@man", "don't tag me, I'm saving the night");
        _comments.DisplayNumComments();
    }



}
