class SimpleGoal : BaseGoal
{
    public SimpleGoal(int pointsValue, string goalName, string goalDescription, double maxCompletions, int totalCompletions, int pointsTotal) :
    base(pointsValue, goalName, goalDescription, maxCompletions, totalCompletions, pointsTotal)
    {
        SetMaxCompletions(1);
    }
    public SimpleGoal(int pointsValue, string goalName, string goalDescription, double maxCompletions) :
    base(pointsValue, goalName, goalDescription, maxCompletions)
    {
        SetMaxCompletions(1);
    }
    
    
}