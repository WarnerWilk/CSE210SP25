class Reflection : Activity
{
    private DateTime _endTime;
    List<string> _prompts =
    ["Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless.",
    "Think of a time when you were incredibly patient.",
    "Think of a time when you forgave someone.",
    "Think of a moment you felt truly at peace.",
    "Think of a time when you were proud of your kindness.",
    "Think of a time when you gave something without expecting anything in return.",
    "Think of a moment you deeply connected with someone.",
    "Think of a time you made someone smile.",
    "Think of a time when you were grateful for something small.",
    "Think of a moment when you felt strong and capable.",
    "Think of a time you overcame a fear.",
    "Think of a time when you chose to do the right thing, even when it was hard.",
    "Think of a moment you felt truly loved.",
    "Think of a time you made a mistake and learned from it.",
    "Think of a time when you listened without judging.",
    "Think of a moment you felt hopeful about the future.",
    "Think of a time you showed courage in a tough situation."];

    List<string> _reflectQuestions =
    ["Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?",
    "What strengths did you use during this experience?",
    "How did others respond to your actions?",
    "What would you do differently next time, if anything?",
    "Did this experience change how you see yourself or others?",
    "What values did you express in this moment?",
    "How did this experience affect your mindset or emotions?",
    "Would you want to share this story with someone? Why or why not?",
    "How long did the effects of this experience last?",
    "What did you sacrifice, if anything, in this experience?",
    "What does this experience say about who you are as a person?",
    "How can this experience inspire your choices going forward?"];
    public Reflection() : base("Reflection", "Take some time and respond to these prompts.") { }
    
        public void StartReflection()
    {
        StartActivity();
        _endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < _endTime)
        {
            Random prompt = new Random();
            Random question = new Random();
            Console.WriteLine(_prompts[prompt.Next(0, _prompts.Count())]);
            Console.WriteLine(_reflectQuestions[question.Next(0, _reflectQuestions.Count())]);
            Wait(30, "SPINNER");
        }
        EndActivity();
    }

}