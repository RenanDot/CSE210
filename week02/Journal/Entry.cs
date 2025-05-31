using System;
using System.Collections.Generic;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _entryText;

    public Entry()
    {
    }
    public Entry(string date, string prompt, string entryText)
    {
        _date = date;
        _prompt = prompt;
        _entryText = entryText;
    }
    
}