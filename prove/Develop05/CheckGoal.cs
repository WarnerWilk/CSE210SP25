class CheckGoal : BaseGoal
{
    private int _bonusPoints;
    public CheckGoal(int pointsValue, string goalName, string goalDescription, double maxCompletions, int bonusPoints) :
    base(pointsValue, goalName, goalDescription, maxCompletions)
    {
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
        if (_completions >= _maxCompletions)
        {
            _completed = true;
            EarnBonusPoints();
        }
    }
    
}