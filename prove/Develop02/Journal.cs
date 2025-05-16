class Journal : Entry
{
    private List<string> _journalEntries = new List<string>();
    private string _fileName = "";

    public void LoadJournal()
    {
        Console.WriteLine($"What is the name of the file you want loaded?");
        _fileName = Console.ReadLine();
        try
        {
            string[] initialEntries = File.ReadAllLines(_fileName);
            List<string> entries = new List<string>(initialEntries);
            Console.WriteLine($"{_fileName} was succesfully loaded");
            _journalEntries = entries;
        }
        catch
        {
            Console.WriteLine($"{_fileName} couldn't be loaded");
        }

    }
    public void NewJournalEntry()
    {
        Entry entry = new Entry();
        _journalEntries.Add(entry.NewEntry());
    }
    public void SaveJournal()
    {
        Console.WriteLine($"Would you like to save to {_fileName}?(Y/N)");
        if (Console.ReadLine().ToUpper() == "N")
        {
        Console.WriteLine($"What file do you want to save this journal to? (Include file type such as 'Example.txt')");
        _fileName = Console.ReadLine();
        }

        using (StreamWriter writer = new StreamWriter(_fileName))
        {
            foreach (string entry in _journalEntries)
            {
                writer.WriteLine($"{entry}");
            }
        }
    }

    public void DisplayJournal()
    {
        int index = 1;
        foreach (string entry in _journalEntries)
        {
            Console.WriteLine($"{index}. {entry}");
            index++;
        }
    }

    public void RemoveEntry()
    {
        DisplayJournal();
        Console.WriteLine("Enter '0' to exit removal.");
        Console.WriteLine($"What number entry would you like to remove?(Integer between 1 and {_journalEntries.Count})");
        try
        {
            int index = int.Parse(Console.ReadLine());
            _journalEntries.RemoveAt(index - 1);
        }
        catch
        {
            Console.WriteLine("Invalid input, nothing has been removed.");
        }
    }
}