using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;  // Length in seconds

    private float _lenghtMinutes; 
    private List<Comment> Comments;

    public Video(string title, string author, int length, List<Comment> comments = null)
    {
        _title = title;
        _author = author;
        _length = length;
        Comments = comments ?? new List<Comment>();
    }

    private int NumberOfComments
    {
        get { return Comments.Count; }
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        _lenghtMinutes = (float)_length / 60;
        Console.WriteLine($"Length: {_lenghtMinutes:F2} minutes or {_length} seconds");
        Console.WriteLine($"Number of Comments: {NumberOfComments}");
        Console.WriteLine("\nComments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine(comment.GetComment());
        }
    }
}