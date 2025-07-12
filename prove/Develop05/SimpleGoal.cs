class SimpleGoal : BaseGoal
{
    public SimpleGoal(int pointsValue, string goalName, string goalDescription, double maxCompletions, int totalCompletions) :
    base(pointsValue, goalName, goalDescription, maxCompletions, totalCompletions)
    {
        SetMaxCompletions(1);
    }
    public SimpleGoal(int pointsValue, string goalName, string goalDescription, double maxCompletions) :
    base(pointsValue, goalName, goalDescription, maxCompletions)
    {
        SetMaxCompletions(1);
    }
    
    
}