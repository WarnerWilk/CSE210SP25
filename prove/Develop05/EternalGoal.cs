class EternalGoal : BaseGoal
{
    private int _benchmark;
    private int _bonusPoints;
    public EternalGoal(int pointsValue, string goalName, string goalDescription, int maxCompletions, int bonusPoints) :
    base(pointsValue, goalName, goalDescription, maxCompletions)
    {
        double infinite = double.PositiveInfinity;
        SetMaxCompletions(infinite);
        _benchmark = maxCompletions;
        _bonusPoints = bonusPoints;

    }
    private void EarnBonusPoints()
    {
        _pointsTotal += _bonusPoints;
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