using System;
using System.Net;
using System.Collections.Generic;

class Word
{
    private String _text;
    private bool _isHidden = false;

    public Word(String text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public String GetDisplayText()
    {
        if (IsHidden())
        {

            return "";

        }
        else
        {
            return _text;
        }
    }
}