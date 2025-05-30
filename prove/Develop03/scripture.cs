using System.Drawing;

class Scripture
{
    private string _reference;
    private List<string> _words = new List<string> {"Hello", "there", "I", "am", "Bob"};
    private List<int> _hiddenwords = new List<int> {};
    //private int _difficulty;

    public void DisplayScripture()
    {
        Console.Clear();
        Word print = new Word();
        for (int i = 0; i < _words.Count; i++)
        {
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

}