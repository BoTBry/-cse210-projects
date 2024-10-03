using System;
using System.Collections.Generic;
using System.Net;
class Myjournal
{
    public String _entry01;
    public String _entry02;
    public String _entry03;

    public void SaveToFile(List<Myjournal> response)
    {
        Console.WriteLine("Saving file.....");
        Console.Write("Please input a file name: ");

        String nameFile = Console.ReadLine();
        String storeName = nameFile+".txt";
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("----------------------------------------");
        Console.ForegroundColor = ConsoleColor.Gray;


        using(StreamWriter OutputFile = new StreamWriter(storeName))
        {
            foreach (Myjournal i in response)
            {
                OutputFile.WriteLine($"{i._entry01}%{i._entry02}%{i._entry03}%");
            }
        }

    }
    public List<Myjournal> ReadFromFile()
    {
        List<Myjournal> response = new List<Myjournal>();
        Console.Write("Please input a file name you would like to load: ");

        String nameFile = Console.ReadLine();
        String storeName = nameFile+".txt";
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("----------------------------------------");
        Console.ForegroundColor = ConsoleColor.Gray;

        string[] lines = System.IO.File.ReadAllLines(storeName);

        foreach (string line in lines)
        {
            string[] split = line.Split("%");

            Myjournal newphase = new Myjournal();
            newphase._entry01 = split[0];
            newphase._entry02 = split[1];
            newphase._entry03 = split[2];

            response.Add(newphase);
        }

        return response;
    }
}