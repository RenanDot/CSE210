using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to show.");
            return;
        }

        foreach (var entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt} - Entry: {entry._entryText}");
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            if (line.StartsWith("Date,Prompt,EntryText")) // Skip header
                continue;

            string[] parts = line.Split(',');
            if (parts.Length < 3)
            {
                Console.WriteLine($"Invalid entry format: {line}");
                continue;
            }

            string date = parts[0].Trim();
            string prompt = parts[1].Trim();
            string entryText = parts[2].Trim();

            Entry entry = new Entry(date, prompt, entryText);
            _entries.Add(entry);
        }
    }


    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine("Date,Prompt,EntryText");
            foreach (var entry in _entries)
            {
                string date = entry._date.Replace(",", " ");
                string prompt = entry._prompt.Replace(",", " ");
                string entryText = entry._entryText.Replace(",", " ");
                writer.WriteLine($"{date},{prompt},{entryText}");
            }
        }
        Console.WriteLine($"Journal saved as CSV to {file}");
    }
    

}