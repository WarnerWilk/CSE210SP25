class BaseGoal
{
    private int _pointsValue;
    private int _pointsTotal;
    private int _completions;
    private string _goalName;
    private string _goalDescription;
    private int _maxCompletions;
    private bool _completed;

    public BaseGoal(int pointsValue, string goalName, string goalDescription, int maxCompletions)
    {
        _pointsValue = pointsValue;
        _goalName = goalName;
        _goalDescription = goalDescription;
        _maxCompletions = maxCompletions;
    }

    public void EarnPoints()
    {
        _pointsTotal += _pointsValue;
    }
    public int GetPoints()
    {
        return _pointsTotal;
    }
    public abstract void CreateGoal()
    {
        
    }
}