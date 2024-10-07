using System;
using System.Net;
using System.Collections.Generic;

class Reference
{
    private String _book;
    private int _chapter;
    private int _verse;
    private int _endverse;

    public Reference(String book, int chapter, int verse )
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(String book, int chapter, int Startverse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _endverse = endverse;

    }

    // public String GetDisplayText()
    // {

    // }
}