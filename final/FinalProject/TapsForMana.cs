class TapsForMana : Card
{
    List<int> _generatedMana = [0, 0, 0, 0, 0, 0];
    TapsForMana(string name, string cardText, List<int> manaCost, bool isLegendary, string colorIdentity, List<int> generatedMana) :
    base(name, cardText, manaCost, isLegendary, colorIdentity)
    {
        _name = name;
        _cardText = cardText;
        _manaCost = manaCost;
        _isLegendary = isLegendary;
        _colorIdentity = colorIdentity;
        _generatedMana = generatedMana;
    }


    virtual public string ManaTap()
    {
        return GetCMC(_generatedMana);
    }
}