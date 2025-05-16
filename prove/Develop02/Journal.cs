class Journal : Entry
{
    public List<string> _journalEntries = new List<string>();

    public void LoadJournal()
    {
        Console.WriteLine($"What is the name of the file you want loaded?");
        string fileName = Console.ReadLine();
        try
        {
            string[] initialEntries = File.ReadAllLines(fileName);
            List<string> entries = new List<string>(initialEntries);
            Console.WriteLine($"{fileName} was succesfully loaded");
            _journalEntries = entries;
        }
        catch
        {
            Console.WriteLine($"{fileName} couldn't be loaded");
        }

    }
    public void NewJournalEntry()
    {
        Entry entry = new Entry();
        _journalEntries.Add(entry.NewEntry());
    }
    public void SaveJournal()
    {
        Console.WriteLine($"What file do you want to save this journal to? (Include file type such as 'Example.txt')");
        string filePath = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (string entry in _journalEntries)
            {
                writer.WriteLine($"{entry}");
            }
        }
    }

    public void DisplayJournal()
    {
        foreach (string entry in _journalEntries)
        {
            Console.WriteLine($"{entry}");
        }
    }

    public void EditJournal()
    {
        
        Console.WriteLine($"What number entry would you like to edit?");

    }
}