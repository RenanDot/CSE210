using System;
using System.Collections.Generic;
using System.Xml.Serialization;

public class Comment
{
    public string _name;
    public string _textComment;

    public Comment(string name, string textComment)
    {
        _name = name;
        _textComment = textComment;
    }

    public Comment()
    {
        _name = "Anonymous";
        _textComment = "No comment provided.";
    }

    public string GetComment()
    {
        return $"{_name}: {_textComment}";
    }
}