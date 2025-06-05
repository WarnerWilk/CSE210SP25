class Policeman : Person
{
    string _weapon;
    public Policeman(string firstName, string lastName, int age, string weapon)
    : base(firstName, lastName, age)
    {
        _weapon = weapon;
    }

    public string GetPoliceInformation()
    {
        return $"{GetPersonInformation()} Weapons: {_weapon}";
    }
}