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
    public string GetWritingAssignment()
    {
        string assignment = _title;
        return assignment;
    }

}