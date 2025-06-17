class Doctor : Person
{
    private double _salary;
    private string _tools;
    public Doctor(string firstName, string lastName, int age, string tools, double salary)
    : base(firstName, lastName, age)
    {
        _salary = salary;
        _tools = tools;
    }

    public override string GetPersonInformation()
    {
        return $"{base.GetPersonInformation()}, Tools: {_tools}";
    }
    public override double GetSalary()
    {
        
        return _salary;
    }
}