using System;
using System.Collections.Generic;

public class Word
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

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            foreach (char letter in _text)
            {
                return "_" + new string('_', _text.Length - 1);
            }
        }
        else
        {
            return _text;
        }

        return _text;
    }
    
}