public class Assignment
{
    string _studentName;
    string _topic;

    public Assignment()
    {
        _studentName = "";
        _topic = "";
    }
    public Assignment(string studentName)
    {
        _studentName = studentName;
    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        string summary = $"Name: {_studentName}\nTopic: {_topic}\n";
        return summary;
    }
}