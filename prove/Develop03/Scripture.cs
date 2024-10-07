using System;
using System.Net;
using System.Collections.Generic;

class Scripture
{
    private Reference _Reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        string[] split = text.Split(" ");
        _Reference = reference;
        foreach (var words in split)
        {
            _words.Add(new Word(words));

        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random randomNum = new Random();

        int hidden = 0;
        while(hidden < numberToHide)
        {

        int counter = randomNum.Next(0, _words.Count);
        if(!_words[counter].IsHidden())
        {
            _words[counter].Hide();
            hidden++;
        }
        else
        {
            _words[counter].Show();
        }

        }
    }
    
    public string GetDisplayText()
    {
        return "hello world";
    }

    public bool IscomplrtrlyHidden()
    {
        return false;
    }
}