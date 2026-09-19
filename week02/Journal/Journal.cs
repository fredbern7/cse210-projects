using System;
using System.Collections.Generic; 
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry) 
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        Console.WriteLine("Loading from: " + Path.GetFullPath(file));
        if (File.Exists(file))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split("~");

                if (parts.Length >= 3)
                {
                    string date = parts[0];
                    string question = parts[1];
                    string entryText = parts[2];

                    Entry newEntry = new Entry();
                    newEntry._date = date;
                    newEntry._promptText = question;
                    newEntry._entryText = entryText;
                    
                    AddEntry(newEntry);
                }
            }
        }
    }
}