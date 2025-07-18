class ManaRock : TapsForMana
{
    private int _shockManaDamage = 0;
    public ManaRock(string name, string cardText, List<int> manaCost, bool isLegendary, string colorIdentity, List<int> generatedMana, int shockManaDamage) :
    base(name, cardText, manaCost, isLegendary, colorIdentity, generatedMana)
    {
        _shockManaDamage = shockManaDamage;
        if (isLegendary == false)
        {
            _cardType = "Artifact";
        }
        else
        {
            _cardType = "Legendary Artifact";
        }

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

        Console.WriteLine($"Does this mana rock deal damage to you when it is tapped?(Y/N)");
        if (Console.ReadLine().ToUpper() == "Y")
        {
            Console.WriteLine("How much damage does this do?");
            _shockManaDamage = Int32.Parse(Console.ReadLine());
        }
    }
}