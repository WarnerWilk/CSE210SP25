using System;
using System.ComponentModel.Design;
using System.Xml.Serialization;
using System.IO;
using System.Text.Json;


class Journal : Entry
{
    public List<Entry> JournalEntries = new List<Entry>();

    public void loadJournal()
    {
        
    }
    public void newJournalEntry()
    {
        Entry entry = new Entry();

        Console.WriteLine($"What file do you want this written to? (Include file type such as 'Example.txt')");
        string filePath = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine($"{entry.newEntry()}");
        }
    }
}