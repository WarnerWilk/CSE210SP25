class Policeman : Person
{
    private double _salary;
    string _weapon;
    public Policeman(string firstName, string lastName, int age, string weapon, double salary)
    : base(firstName, lastName, age)
    {
        _weapon = weapon;
        _salary = salary;
    }


    public override string GetPersonInformation()
    {
        return $"{base.GetPersonInformation()}, Weapons: {_weapon}";
    }

    public override double GetSalary()
    {
        return _salary;
    }

}