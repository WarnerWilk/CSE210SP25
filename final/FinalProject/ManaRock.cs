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
}