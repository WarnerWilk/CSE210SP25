class EternalGoal : BaseGoal
{
    private double _benchmark;
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
}