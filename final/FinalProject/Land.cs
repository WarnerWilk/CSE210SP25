class Land : TapsForMana
{
    public Land(string name, string cardText, List<int> manaCost, bool isLegendary, string colorIdentity, List<int> generatedMana) :
    base(name, cardText, manaCost, isLegendary, colorIdentity, generatedMana)
    {
        _manaCost = [0, 0, 0, 0, 0, 0];
    }
}