class Breathing : Activity
{
    public Breathing() : base("Breathing", "Take some time to breath deeply."){}
    private List<string> _breaths = ["Inhale...", "Exhale..."];
    public void StartBreathing()
    {
        StartActivity();
        for (int i = 0; i < _duration/4; i++)
        {
            Console.WriteLine(_breaths[i % 2]);
            Thread.Sleep(4000);
        }
        EndActivity();
    }
}