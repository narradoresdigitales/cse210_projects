using System;
using System.Diagnostics;
using System.IO;
public class Journal 
{

    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("\n saved \n");
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
            outputFile.WriteLine("date~prompt~answer");
        
            foreach (Entry i in _entries)    
            {
                outputFile.WriteLine($"{i._date}~{i._promptText}~{i._entryText}");
            }    
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        Entry anEntryFromFile;

        string[] lines = System.IO.File.ReadAllLines(file);

        if (lines.Length > 0)
        {
            foreach (string line in lines)
            {
                string[] paragraph = line.Split("~");
                anEntryFromFile = new Entry();
                anEntryFromFile._date = paragraph[0];
                anEntryFromFile._promptText = paragraph[1];
                anEntryFromFile._entryText = paragraph[2];

                _entries.Add(anEntryFromFile);
            }
            _entries.RemoveAt(0);
        }
        else
        {
            Console.WriteLine("\n The file is empty\n");
        }
    }
}
