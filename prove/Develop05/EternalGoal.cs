class EternalGoal : BaseGoal
{
    private double infinite = double.PositiveInfinity;
    private double _benchmark;
    public EternalGoal(int pointsValue, string goalName, string goalDescription, double maxCompletions, int totalCompletions, int pointsTotal) :
    base(pointsValue, goalName, goalDescription, maxCompletions, totalCompletions, pointsTotal)
    {
        
        SetMaxCompletions(infinite);
        _benchmark = maxCompletions;
    }
    public EternalGoal(int pointsValue, string goalName, string goalDescription, double maxCompletions) :
    base(pointsValue, goalName, goalDescription, maxCompletions)
    {
        double infinite = double.PositiveInfinity;
        SetMaxCompletions(infinite);
        _benchmark = maxCompletions;
    }
    private void EarnBonusPoints()
    {
        _pointsTotal += _pointsValue;
    }
    public override void RecordEvent()
    {
        _completions++;
        EarnPoints();
        if ((_completions % _benchmark) == 0)
        {
            EarnBonusPoints();
        }
    }
    override public string GetGoal()
    {
        string goal;
        if (_completed == true)
        {
            goal = $"[X]#{_goalName}#{_goalDescription}#{_pointsValue}#{_pointsTotal}#{_completions}#{infinite}";
        }
        else
        {
            goal = $"[ ]#{_goalName}#{_goalDescription}#{_pointsValue}#{_pointsTotal}#{_completions}#{infinite}";
        }
        return goal;
    }
}