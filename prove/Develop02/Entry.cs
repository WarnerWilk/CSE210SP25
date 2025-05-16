class Entry
{
   
    Random random = new Random();

    List<string> Prompts = new List<string>
    {
        "How did you feel the Spirit today?",
        "What spiritual insight or prompting did you have today?",
        "Did you see God’s hand in your life today? How?",
        "What scripture, talk, or spiritual message stood out to you today?",
        "What did you do today that helped you come closer to Christ?",
        "Did you serve someone today? How did it affect you?",
        "What prayer was answered today, even in a small way?",
        "What truth did you feel reaffirmed today?",
        "How did you live your covenants today?",
        "What did you learn from the Come, Follow Me study or other gospel study today?",

        "What did you learn today—spiritually, mentally, or emotionally?",
        "What did you do today that took courage?",
        "How did you grow as a person today?",
        "What’s one thing you’d do differently if you could relive today?",
        "What was the biggest challenge you faced today, and how did you respond?",
        "What was one choice you made today that aligned with your values?",
        "What did you do that stretched your faith or trust in God?",

        "Who was the most interesting person you talked to today?",
        "Did someone teach you something today, directly or indirectly?",
        "How did you show love to someone today?",
        "Was there a conversation today that left you thinking afterward?",
        "Who influenced your mood or mindset today—and how?",
        "Did you feel prompted to reach out to someone today?",

        "What did you enjoy the most today?",
        "What made you laugh or smile today?",
        "What moment today felt meaningful or memorable?",
        "Where did you feel most at peace today?",
        "What are you grateful for today?",
        "Did you notice something beautiful or unexpected today?",

        "If today were the last entry in your journal, what would you want your posterity to know about this day?",
        "What would you tell your future self about how you handled today?",
        "How did today contribute to your long-term goals—temporal or eternal?",
        "What testimony-building experience happened today?",
        "What kind of person were you today?"
    };

    public string NewEntry()
    {
        string prompt = Prompts[random.Next(Prompts.Count)];
        Console.WriteLine($"{prompt}");
        string response = Console.ReadLine();
        DateTime entryDateTime = DateTime.Now;
        string entry = $"{entryDateTime} ` {prompt} ` {response}";
        // Console.WriteLine($"{entry}");
        return entry;
    }
}