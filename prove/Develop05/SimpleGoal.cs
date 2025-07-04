class SimpleGoal : BaseGoal
{
    public SimpleGoal(int pointsValue, string goalName, string goalDescription, int maxCompletions) :
    base(pointsValue, goalName, goalDescription, maxCompletions)
    {
        SetMaxCompletions(1);
    }
    
    
}