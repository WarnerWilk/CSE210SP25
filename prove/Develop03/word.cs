class Word
{
    private string word;

    public Word()
    {
        word = "";
    }
    public Word(string input)
    {
        word = input;
    }

    public void ChangeWord(string input)
    {
        word = input;
    }

    public void Display()
    {
        Console.Write($"{word} ");
    }
    public void Hide()
    {
        for (int i = 0; i < word.Length; i++)
        {
            Console.Write("_");
        }
        Console.Write(" ");
    }
}