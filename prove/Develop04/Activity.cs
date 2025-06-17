class Activity
{
    protected int _duration;
    private string _activityName;
    private string _activityDescription;

    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    public void getDuration()
    {
        Console.WriteLine("How long should this activity last?");
        _duration = Int32.Parse(Console.ReadLine());
    }

    public void Wait(int length, string mode)
    {
        if (mode.ToUpper() == "DEPLETE")
        {
            Console.WriteLine();
            for (int i = length; i > 0; i--)
            {
                Console.Write(".");
            }
        }
        for (int i = length; i > 0; i--)
            {
                List<string> spinner = ["/", "|", "\\", "—"];
                if (mode.ToUpper() == "COUNTDOWN")
                {
                    if (i > 8)
                    {
                        Console.Write($"\b \b");
                    }
                    Console.Write($"\b \b");
                    Console.Write(i);
                }
                else if (mode.ToUpper() == "SPINNER")
                {

                    Console.Write($"\b{spinner[i % 4]}");
                }
                if (mode.ToUpper() == "DEPLETE")
                {
                    Console.Write("\b \b");
                }
                Thread.Sleep(1000);
            }
        Console.WriteLine();
    }

    public void StartActivity()
    {
        Console.WriteLine($"You're about to start {_activityName}.\n{_activityDescription}");
        getDuration();
        Console.WriteLine($"{_activityName} is about to start. Prepare for a few seconds.");
        Wait(10, "COUNTDOWN");
    }

    public void EndActivity()
    {
        Console.WriteLine("Great job!\n");
        Console.WriteLine($"You just finished doing {_activityName} for {_duration} seconds.");
        Wait(10, "SPINNER");
    }
    
}