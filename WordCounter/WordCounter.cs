class WordCounter
{
    private List<string> _words;
    private int _wordCount = 0;
    public WordCounter(string text)
    {
        _words = new List<string>();
        SplitTextIntoWords(text);
    }

    private void SplitTextIntoWords(string text)
    {
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            _words.Add(word);
        }
    }

    public void DisplayWords()
    {
        foreach (string word in _words)
        {
            Console.WriteLine(word);
        }
    }

    public int CountWords()
    {
        foreach (string word in _words)
        {
            _wordCount += 1;
        }
        return _wordCount;
    }

    public int CountSingleWord(string searchWord)
    {
        int count = 0;

        foreach (string word in _words)
        {
            if (word.ToUpper() == searchWord.ToUpper())
            {
                count++;
            }
        }
        return count;
    }
}