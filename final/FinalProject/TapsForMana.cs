class TapsForMana : Card
{
    protected List<int> _generatedMana = [0, 0, 0, 0, 0, 0];
    public TapsForMana(string name, string cardText, List<int> manaCost, bool isLegendary, string colorIdentity, List<int> generatedMana) :
    base(name, cardText, manaCost, isLegendary, colorIdentity)
    {
        _name = name;
        _cardText = cardText;
        _manaCost = manaCost;
        _isLegendary = isLegendary;
        _colorIdentity = colorIdentity;
        _generatedMana = generatedMana;
    }

    public void SetGeneratedMana(List<int> generatedMana)
    {
        _generatedMana = generatedMana;
    }

    virtual public string ManaTap()
    {
        return GetCMC(_generatedMana);
    }
    public override void CreateCard()
    {
        base.CreateCard();

        Console.WriteLine("How much red mana does the card tap for?");
        _generatedMana[0] = Int32.Parse(Console.ReadLine());

        Console.WriteLine("How much green mana does the card tap for?");
        _generatedMana[1] = Int32.Parse(Console.ReadLine());

        Console.WriteLine("How much blue mana does the card tap for?");
        _generatedMana[2] = Int32.Parse(Console.ReadLine());

        Console.WriteLine("How much white mana does the card tap for?");
        _generatedMana[3] = Int32.Parse(Console.ReadLine());

        Console.WriteLine("How much black mana does the card tap for?");
        _generatedMana[4] = Int32.Parse(Console.ReadLine());

        Console.WriteLine("How much colorless mana does the card tap for?");
        _generatedMana[5] = Int32.Parse(Console.ReadLine());

    }
}