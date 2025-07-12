class CheckGoal : BaseGoal
{
    private int _bonusPoints;
    public CheckGoal(int pointsValue, string goalName, string goalDescription, double maxCompletions, int totalCompletions, int bonusPoints) :
    base(pointsValue, goalName, goalDescription, maxCompletions, totalCompletions)
    {
        _bonusPoints = bonusPoints;
    }
    public CheckGoal(int pointsValue, string goalName, string goalDescription, double maxCompletions,int bonusPoints) :
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
    
    override public string GetGoal()
    {
        string goal;
        if (_completed == true)
        {
            goal = $"[X]#{_goalName}#{_goalDescription}#{_pointsValue}#{_pointsTotal}#{_completions}#{_maxCompletions}#{_bonusPoints}";
        }
        else
        {
            goal = $"[ ]#{_goalName}#{_goalDescription}#{_pointsValue}#{_pointsTotal}#{_completions}#{_maxCompletions}#{_bonusPoints}";
        }
        return goal;
    }
}