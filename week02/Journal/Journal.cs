using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
public class Journal
{
    
    public List<Entry> _entries = new List<Entry>();
    public Journal()
    {
        
    }
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
        using (StreamWriter outputFile = new StreamWriter($"{file}.txt"))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}");
            }

        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines($"{file}.txt");
        foreach (string line in lines)
            {
                string[] parts = line.Split("~");
                string date = parts[0];
                string promptText = parts[1];
                string entryText = parts[2];

                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._promptText = promptText;
                newEntry._entryText = entryText;
                AddEntry(newEntry);
            }
    }
}