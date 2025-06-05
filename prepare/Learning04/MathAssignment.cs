public class MathAssignment : Assignment
{
    string _textbookSection;
    string _problems;
    public MathAssignment()
    {
        _textbookSection = "";
        _problems = "";
    }
    public MathAssignment(string _studentName, string _topic, string textbookSection, string problems) : base(_studentName, _topic)
    {

        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        string homeworkList = $"{_textbookSection} Problems {_problems}";
        return homeworkList;
    }
    public string GetMathAssignmentInformation()
    {
        return $"{GetSummary()}Assignment: {GetHomeworkList()}";
    }
}