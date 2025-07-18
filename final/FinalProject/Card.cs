using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

abstract class Card
{
    protected string _name, _cardText;
    protected List<int> _manaCost = [0, 0, 0, 0, 0, 0];
    protected bool _isLegendary;
    protected string _colorIdentity;
    protected string _cardType;
    public Card(string name, string cardText, List<int> manaCost, bool isLegendary, string colorIdentity)
    {
        _name = name;
        _cardText = cardText;
        _manaCost = manaCost;
        _isLegendary = isLegendary;
        _colorIdentity = colorIdentity;
    }
    public Card(string name, List<int> manaCost)
    {
        _name = name;
        _manaCost = manaCost;
        _isLegendary = false;
    }
    public Card(string name)
    {
        _name = name;
        _isLegendary = false;
    }

    public Card()
    {
        //To create a blank card. The blank card can be filled in with information using CreateCard()
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

    virtual public void CreateCard()
    {
        Console.Write("Enter card name: ");
        _name = Console.ReadLine();

        Console.Write("Enter card text: ");
        _cardText = Console.ReadLine();

        Console.Write("Is the card legendary? (true/false): ");
        while (!bool.TryParse(Console.ReadLine(), out _isLegendary))
        {
            Console.Write("Please enter 'true' or 'false': ");
        }

        Console.Write("Enter color identity: ");
        _colorIdentity = Console.ReadLine();

        Console.Write("Enter card type(e.g. Creature, Mana Dork, Mana Rock, Vehicle, Land): ");
        _cardType = Console.ReadLine();

        Console.WriteLine("How much red mana does the card cost to cast?");
        _manaCost[0] = Int32.Parse(Console.ReadLine());

        Console.WriteLine("How much green mana does the card cost to cast?");
        _manaCost[1] = Int32.Parse(Console.ReadLine());

        Console.WriteLine("How much blue mana does the card cost to cast?");
        _manaCost[2] = Int32.Parse(Console.ReadLine());

        Console.WriteLine("How much white mana does the card cost to cast?");
        _manaCost[3] = Int32.Parse(Console.ReadLine());

        Console.WriteLine("How much black mana does the card cost to cast?");
        _manaCost[4] = Int32.Parse(Console.ReadLine());

        Console.WriteLine("How much colorless mana does the card cost to cast?");
        _manaCost[5] = Int32.Parse(Console.ReadLine());
    }
}