class BaseGoal
{
    protected int _pointsValue;
    protected int _pointsTotal;
    protected int _completions;
    protected string _goalName;
    protected string _goalDescription;
    protected double _maxCompletions;
    protected bool _completed;

    public BaseGoal(int pointsValue, string goalName, string goalDescription, double maxCompletions)
    {
        _pointsValue = pointsValue;
        _goalName = goalName;
        _goalDescription = goalDescription;
        _maxCompletions = maxCompletions;
    }

    virtual public int GetPointValue()
    {
        return _pointsValue;
    }

    virtual public string GetName()
    {
        return _goalName;
    }
    virtual public string GetDescription()
    {
        return _goalDescription;
    }
    virtual public double GetMax()
    {
        return _maxCompletions;
    }
    virtual public int GetCompletion()
    {
        return _completions;
    }

    public void SetMaxCompletions(double maxCompletions)
    {
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
    public virtual void RecordEvent()
    {
        _completions++;
        EarnPoints();
        if (_completions >= _maxCompletions)
        {
            _completed = true;
        }
    }
    public string GetGoal()
    {
        string goal;
        if (_completed == true)
        {
            goal = $"[X]#{_goalName}#{_goalDescription}#Points/Completion: {_pointsValue}#Total Points: {_pointsTotal}#Completion: {_completions}/{_maxCompletions}";
        }
        else
        {
            goal = $"[ ]#{_goalName}#{_goalDescription}#Points/Completion: {_pointsValue}#Total Points: {_pointsTotal}#Completion: {_completions}/{_maxCompletions}";
        }
        return goal;
    }
}