using System.Security.Cryptography.X509Certificates;

class ManaDork : Creature
{
    List<int> _generatedMana = [0, 0, 0, 0, 0, 0];

    TapsForMana TapMana = new TapsForMana(null, null, [0, 0, 0, 0, 0, 0], false, null, [0, 0, 0, 0, 0, 0]);
    public ManaDork(string name, string cardText, List<int> manaCost, bool isLegendary, string colorIdentity, int power, int toughness, List<int> generatedMana) :
    base(name, cardText, manaCost, isLegendary, colorIdentity, power, toughness)
    {
        if (isLegendary == false)
        {
            _cardType = "Artifact";
        }
        else
        {
            _cardType = "Legendary Artifact";
        }
        _generatedMana = generatedMana;
        TapMana.SetGeneratedMana(_generatedMana);
    }
    virtual public string TapDork()
    {
        return TapMana.ManaTap();
    }

    public override string GetCardInfo()
    {

        string info = base.GetCardInfo() + $"\nTaps for: {GetCMC()}";

        return info;
    }
    
}