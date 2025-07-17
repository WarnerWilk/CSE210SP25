using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

abstract class Card
{
    protected string _name, _cardText;
    protected List<int> _manaCost = [0,0,0,0,0,0];
    protected bool _isLegendary;
    protected string _colorIdentity;
    protected string _cardType;
    protected Card(string name, string cardText, List<int> manaCost, bool isLegendary, string colorIdentity)
    {
        _name = name;
        _cardText = cardText;
        _manaCost = manaCost;
        _isLegendary = isLegendary;
        _colorIdentity = colorIdentity;
    }
    protected Card(string name, List<int> manaCost)
    {
        _name = name;
        _manaCost = manaCost;
        _isLegendary = false;
    }
    protected Card(string name)
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
    virtual public int GetPower()
    {
        return 0;
    }
    virtual public void TakeDamage(int damage)
    {
    }

    public string GetCMC(List<int> mana) //returns the decoded mana cost
    {
        string convertedManaCost = "";
        List<string> colors = ["red", "green", "blue", "white", "black", "colorless"];
        int i = 0;
        foreach (int item in mana)
        {
            if (item != 0)
            {
                convertedManaCost += $"{colors[i]}: {item}; ";
            }
            i++;
        }
        return convertedManaCost;
    }
    public string GetCMC()
    {
        return GetCMC(_manaCost);
    }
    virtual public string GetCardInfo()
    {
        string cardInfo = $"Card Information:\nName: {_name}\nCard Type: {_cardType}\nMana Cost: {GetCMC(_manaCost)}\nColor Identity: {_colorIdentity}\nCard Text: {_cardText}";
        return cardInfo;
    }

}