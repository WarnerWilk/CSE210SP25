using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

abstract class Card
{
    protected string _name, _cardText;
    private List<int> _manaCost = [0,0,0,0,0,0];
    protected bool _isLegendary;
    protected string _colorIdentity;
    protected string _cardType;
    Card(string name, string cardText, List<int> manaCost, bool isLegendary, string colorIdentity)
    {
        _name = name;
        _cardText = cardText;
        _manaCost = manaCost;
        _isLegendary = isLegendary;
        _colorIdentity = colorIdentity;
    }
    Card(string name, List<int> manaCost)
    {
        _name = name;
        _manaCost = manaCost;
        _isLegendary = false;
    }
    Card(string name)
    {
        _name = name;
        _isLegendary = false;
    }
    public string GetCardName()
    {
        return _name;
    }
    virtual public string GetCardText()
    {
        return _cardText;
    }
    public bool GetIsLegendary()
    {
        return _isLegendary;
    }
    abstract public int GetPower();
    abstract public void TakeDamage();
    abstract public Dictionary<string, int> ManaTap();

    public string GetCMC() //returns the decoded mana cost
    {
        string convertedManaCost = "";
        List<string> colors = ["red", "green", "blue", "white", "black", "colorless"];
        int i = 0;
        foreach (int item in _manaCost)
        {
            if (item != 0)
            {
                convertedManaCost += $"{colors[i]}: {item}; ";
            }
            i++;
        }
        return convertedManaCost;
    }
    virtual public string GetCardInfo()
    {
        string cardInfo = $"Card Information:\nName: {_name}\nCard Type: {_cardType}\nMana Cost: {GetCMC()}\nColor Identity: {_colorIdentity}\nCard Text: {_cardText}";
        return cardInfo;
    }

}