class Listing : Activity
{
    private List<string> _responses = [];

    private int _selectedPrompt;

    private Random _promptIndex = new Random();

    private DateTime _endTime;

    private List<string> _prompts =
    ["Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?",
    "What are things that bring you peace?",
    "What blessings have you noticed recently?",
    "What goals are you working on to grow spiritually?",
    "What are some ways you show love to others?",
    "What helps you stay emotionally grounded?",
    "What experiences have strengthened your faith?",
    "Who are people you turn to for support?",
    "What habits help you feel closer to God?",
    "What memories make you feel grateful?",
    "What challenges have helped you grow emotionally?",
    "What are some of your core beliefs or values?",
    "What are ways you receive personal revelation?",
    "What scriptures or quotes have inspired you lately?",
    "What emotions have you felt strongly this week, and why?",
    "What do you feel God is inviting you to work on right now?"];
    public Listing() : base("Listing", "Make a list of answers to the prompt.") { }

    public void StartListing()
    {
        StartActivity();
        _selectedPrompt = _promptIndex.Next(0, _prompts.Count());
        Console.WriteLine(_prompts[_selectedPrompt]);
        Wait(9, "COUNTDOWN");
        _endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < _endTime)
        {
            Console.WriteLine("List off anything that comes to mind, then press 'Enter'");
            _responses.Add(Console.ReadLine());
        }
        Console.WriteLine($"You wrote {_responses.Count()} responses.\nYour responses to '{_prompts[_selectedPrompt]}' were:");
        for (int i = 0; i < _responses.Count(); i++)
        {
            Console.WriteLine($"{_responses[i]}");
        }
        EndActivity();

    }
}