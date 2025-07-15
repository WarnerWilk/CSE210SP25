using System.Collections;

class Goals
{
    private List<BaseGoal> _goals = new List<BaseGoal>();
    private string _fileName = "";
    private int _totalPointsEarned = 0;

    public void GoalToList(BaseGoal goal)
    {
        _goals.Add(goal);
    }

    public void LoadGoals()
    {
        Console.WriteLine($"What is the name of the file you want to load?");
        _fileName = Console.ReadLine();
        try
        {
            string[] loadedGoals = File.ReadAllLines(_fileName);
            foreach (string goal in loadedGoals)
            {

                string[] split = goal.Split("#");
                switch (split[6])
                {
                    case "1":
                        SimpleGoal simpleGoal = new SimpleGoal(Int32.Parse(split[3]), split[1], split[2], Double.Parse(split[6]), Int32.Parse(split[5]), Int32.Parse(split[4]));
                        _goals.Add(simpleGoal);
                        _totalPointsEarned += simpleGoal.GetPoints();
                        break;
                    case "∞":
                        EternalGoal eternalGoal = new EternalGoal(Int32.Parse(split[3]), split[1], split[2], double.PositiveInfinity, Int32.Parse(split[5]), Int32.Parse(split[4]));
                        _goals.Add(eternalGoal);
                        _totalPointsEarned += eternalGoal.GetPoints();
                        break;
                    default:
                        CheckGoal checkGoal = new CheckGoal(Int32.Parse(split[3]), split[1], split[2], Double.Parse(split[6]), Int32.Parse(split[5]), Int32.Parse(split[7]), Int32.Parse(split[4]));
                        _goals.Add(checkGoal);
                        _totalPointsEarned += checkGoal.GetPoints();
                        break;
                }
            }
            Console.WriteLine($"{_fileName} was successfully loaded.");
        }
        catch
        {
            Console.WriteLine($"{_fileName} couldn't be loaded.");
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine($"Would you like to save to {_fileName}? (Y/N)");
        if (Console.ReadLine().ToUpper() == "N")
        {
            Console.WriteLine("What file do you want to save your goals to? (Include file extension like 'goals.txt')");
            _fileName = Console.ReadLine();
        }

        try
        {
            using (StreamWriter writer = new StreamWriter(_fileName))
            {
                foreach (BaseGoal goal in _goals)
                {
                    writer.WriteLine(goal.GetGoal());
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }
        catch
        {
            Console.WriteLine("Invalid filename. Goals not saved.");
        }
    }

    public void NewGoal()
    {
        int earnedPoints;
        int bonusPoints;
        double maxCompletions = 1;

        Console.WriteLine("Enter the name of your new goal: ");
        string goalName = Console.ReadLine();
        Console.WriteLine("Write a description for the goal.");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("What kind of goal do you want to add?");

        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Eternal Goal");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
            case "Simple Goal":
            case "Simple":
                Console.WriteLine("How many points do you want to earn?");
                earnedPoints = Int32.Parse(Console.ReadLine());
                SimpleGoal simpleGoal = new SimpleGoal(earnedPoints, goalName, goalDescription, maxCompletions);
                GoalToList(simpleGoal);
                break;
            case "2":
            case "Checklist Goal":
            case "Checklist":
                Console.WriteLine("How many times do you want to repeat this goal?");
                maxCompletions = Double.Parse(Console.ReadLine());
                Console.WriteLine("How many points do you want to earn?");
                earnedPoints = Int32.Parse(Console.ReadLine());
                Console.WriteLine("How many bonus points do you want to earn once completed?");
                bonusPoints = Int32.Parse(Console.ReadLine());
                CheckGoal checkGoal = new CheckGoal(earnedPoints, goalName, goalDescription, maxCompletions, bonusPoints);
                GoalToList(checkGoal);
                break;
            case "3":
            case "Eternal Goal":
            case "Eternal":
                Console.WriteLine("How many completions do you want to get points?");
                maxCompletions = Double.Parse(Console.ReadLine());
                Console.WriteLine("How many points do you want to earn?");
                earnedPoints = Int32.Parse(Console.ReadLine());
                EternalGoal eternalGoal = new EternalGoal(earnedPoints, goalName, goalDescription, maxCompletions);
                GoalToList(eternalGoal);
                break;

        }

        Console.WriteLine("Goal added.");
    }

    public void RecordGoalEvent()
    {
        Console.WriteLine("Select a goal to record an event:");
        DisplayFile();

        int selection = Int32.Parse(Console.ReadLine());
        _goals[selection - 1].RecordEvent();
        _totalPointsEarned += _goals[selection - 1].GetPointValue();
    }

    public void DisplayFile()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].WriteGoal()}");
        }
        Console.WriteLine($"Your total points earned: {_totalPointsEarned}");
    }

}