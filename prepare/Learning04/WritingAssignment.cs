public class WritingAssignment : Assignment
{
    string _title;
    public WritingAssignment()
    {
        _title = "";
    }
    public WritingAssignment(string _studentName, string _topic, string title) : base(_studentName, _topic)
    {

        _title = title;
    }
    public string GetWritingHomework()
    {
        string assignment = _title;
        return assignment;
    }

    public string GetWritingAssignment()
    {
        return $"{GetSummary()}Assignment: {GetWritingHomework()}";
    }

}