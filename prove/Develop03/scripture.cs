class Scripture
{
    private string _reference;
    private List<string> _words;
    private List<int> _hiddenwords;
    //private int _difficulty;

    public void DisplayScripture()
    {
        //TODO
        //Send random index to HideWord, change that word to underscores in _words, then have some way to save 
        // what words have been removed, and prevent that word from being removed again.

        foreach (string word in _words)
        {
            Console.Write($"{word} ");
        }
    }

    public int RandomWord()
    {
        int verselength = _words.Count();
        int randomIndex;
        Random selection = new Random();
        do
        {
            randomIndex = selection.Next(0, verselength);
        }
        while (!_hiddenwords.Contains(randomIndex));
        _hiddenwords.Add(randomIndex);
        return randomIndex;
    }

}