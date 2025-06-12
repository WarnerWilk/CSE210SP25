class Reference
{
    private string _book;
    private int _chapter;
    private int _startverse;
    private int _endverse;

    public Reference()
    {
        _book = "Genesis";
        _chapter = 1;
        _startverse = 1;
        _endverse = 1;
    }

    // public Reference(string reference)
    // {
    //     // string[] tempreference = reference.Split(" ");
    //     // _book = tempreference[0];
    //     // string tempnumbers1 = tempreference[1];
    //     // _chapter = int.Parse(tempreference[1]);
    //     // string tempverse = tempreference[2];
    //     // try
    //     // {
    //     //     string[] tempversesplit = tempverse.Split("-");
    //     //     _startverse = int.Parse(tempversesplit[0]);
    //     //     _endverse = int.Parse(tempversesplit[1]);
    //     // }
    //     // catch
    //     // {
    //     //     _startverse = int.Parse(tempreference[2]);
    //     //     _endverse = int.Parse(tempreference[2]);
    //     // }
    // }

    public Reference(string book, int chapter)
    {
        _book = book;
        _chapter = chapter;
        _startverse = 1;
        _endverse = 1;
    }

    public Reference(string book, int chapter, int startverse)
    {
        _book = book;
        _chapter = chapter;
        _startverse = startverse;
        _endverse = startverse;
    }

    public Reference(string book, int chapter, int startverse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _startverse = startverse;
        _endverse = endverse;
    }

    public void SetReference(string book, int chapter, int startverse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _startverse = startverse;
        _endverse = endverse;
    }

    public string GetReference()
    {
        string reference;
        if (_startverse != _endverse)
        {
            reference = ($"{_book} {_chapter}:{_startverse}-{_endverse}");
        }
        else
        {
            reference = ($"{_book} {_chapter}:{_startverse}");
        }
        return reference;
    }

}