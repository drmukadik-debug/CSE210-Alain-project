// In this class I add the possibility for the user to save data as JSON
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

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

    public void SaveToFile(string fileName)
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            IncludeFields = true
        };

        string json = JsonSerializer.Serialize(_entries, options);

        File.WriteAllText(fileName, json);
    }

    public void LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            IncludeFields = true
        };

        string json = File.ReadAllText(fileName);

         _entries = JsonSerializer.Deserialize<List<Entry>>(json, options)
               ?? new List<Entry>();
        }

    }


