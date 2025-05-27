class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        WordCounter wordCounter = new WordCounter("The quick brown fox jumped over the lazy dog.");
        wordCounter.DisplayWords();
        Console.WriteLine(wordCounter.CountWords());
    }
}