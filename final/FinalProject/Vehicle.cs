class Vehicle : Creature
{
    private bool _isCrewed = false;

    private int _crew = 0;
    public Vehicle(string name, string cardText, List<int> manaCost, bool isLegendary, string colorIdentity, int power, int toughness, int crew) :
    base(name, cardText, manaCost, isLegendary, colorIdentity, power, toughness)
    {
        _crew = crew;

        if (isLegendary == false)
        {
            _cardType = "Artifact";
        }
        else
        {
            _cardType = "Legendary Artifact";
        }
    }

    public void Crew(int creaturePower)
    {
        if (creaturePower >= _crew)
        {
            _isCrewed = true;
            Console.WriteLine($"{_name} was crewed.");
        }
        else
        {
            _isCrewed = false;
            Console.WriteLine($"Insufficient power to crew {_name}.");
        }
    }

    public override int GetPower()
    {
        if (_isCrewed == true)
        {
            return _power;
        }
        else
        {
            Console.WriteLine($"{_name} isn't crewed!");
            return 0;
        }
    }

    public override void TakeDamage(int damage)
    {
        if (_isCrewed == true)
        {
            base.TakeDamage(damage);
        }
        else
        {
            Console.WriteLine($"{_name} isn't crewed!");
        }
    }
    public override void CreateCard()
    {
        base.CreateCard();

        Console.WriteLine($"What is the crew value for this vehicle?");
        _crew = Int32.Parse(Console.ReadLine());
    }
}