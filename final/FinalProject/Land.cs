class Land : TapsForMana
{
    private int _shockManaDamage = 0;
    public Land(string name, string cardText, List<int> manaCost, bool isLegendary, string colorIdentity, List<int> generatedMana, int shockManaDamage) :
    base(name, cardText, manaCost, isLegendary, colorIdentity, generatedMana)
    {
        _generatedMana = [0, 0, 0, 0, 0, 0];

        _shockManaDamage = shockManaDamage;
        if (isLegendary == false)
        {
            _cardType = "Land";
        }
        else
        {
            _cardType = "Legendary Land";
        }
        switch (_name)
        {
            case "Mountain":
                _generatedMana[0]++;
                break;
            case "Forest":
                _generatedMana[1]++;
                break;
            case "Island":
                _generatedMana[2]++;
                break;
            case "Plains":
                _generatedMana[3]++;
                break;
            case "Swamp":
                _generatedMana[4]++;
                break;
            default:
                _generatedMana = generatedMana;
                break;
        }
    }

    public Land() : base()
    {
        
    }

    public override string ManaTap()
    {
        if (_shockManaDamage > 0)
        {
            Console.WriteLine($"Take {_shockManaDamage} damage.");
        }
        return base.ManaTap();
    }

    public override void CreateCard()
    {
        base.CreateCard();

        Console.WriteLine($"Does this land deal damage to you when it is tapped?(Y/N)");
        if (Console.ReadLine().ToUpper() == "Y")
        {
            Console.WriteLine("How much damage does this do?");
            _shockManaDamage = Int32.Parse(Console.ReadLine());
        }
    }
}