using System.Drawing;

class Scripture
{
    private List<string> _words = new List<string> {"In", "the", "beginning", "God", "created", "the", "heavens", "and", "the", "earth."};
    private List<int> _hiddenwords = new List<int> { };
    //private int _difficulty;
    private Reference _reference = new Reference();
    private int _difficulty = 1;

    public void SetDifficulty()
    {
        Console.WriteLine($"How many words would you like to disappear each time?");
        string response = Console.ReadLine();
        int difficulty = Int32.Parse(response);
        
        if (difficulty > _words.Count())
        {
            _difficulty = _words.Count();
        }
        else if (difficulty < _words.Count())
        {
            _difficulty = difficulty;
        }
    }

    public string DisplayScripture()
    {
        Console.Clear();
        Word print = new Word();
        Console.WriteLine(_reference.GetReference());
        for (int i = 0; i < _words.Count; i++)
        {
            for (int r = 0; r < _difficulty; r++)
            {
                RandomWord();
            }
            print.ChangeWord(_words[i]);
            if (_hiddenwords.Contains(i))
            {
                print.Hide();
            }
            else
            {
                print.Display();
            }
        }
        if (_hiddenwords.Count() == _words.Count())
        {
            return "quit";
        }
        return "0";
    }

    public int RandomWord()
    {
        int verselength = _words.Count();
        int randomIndex;
        Random selection = new Random();
        if (_hiddenwords.Count == _words.Count)
        {
            _hiddenwords.Clear();
        }
        do
        {
            randomIndex = selection.Next(0, verselength);
        }
        while (_hiddenwords.Contains(randomIndex));
        _hiddenwords.Add(randomIndex);
        return randomIndex;
    }

    public void SetScripture()
    {
        Console.WriteLine("What book is the scripture in? (e.g. Genesis, Matthew, 1 Nephi, Doctrine and Covenants, Abraham, etc.)");
        string book = Console.ReadLine();
        Console.WriteLine("What chapter?");
        int chapter = int.Parse(Console.ReadLine());
        Console.WriteLine("Starting with what verse?");
        int startverse = int.Parse(Console.ReadLine());
        Console.WriteLine("Ending with what verse?(Just put in the same as previous if it's only one verse)");
        int endverse = int.Parse(Console.ReadLine());
        _reference.SetReference(book, chapter, startverse, endverse);
        Console.WriteLine("What is the text of the verse?");
        string contents = Console.ReadLine();
        string[] splitverse = contents.Split(" ");
        _words = splitverse.ToList();
    }

}