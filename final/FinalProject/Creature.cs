using Microsoft.VisualBasic;

class Creature : Card
{
    int _power = 0;
    int _toughness = 0;
    
    public Creature(string name, string cardText, List<int> manaCost, bool isLegendary, string colorIdentity, int power, int toughness) :
    base(name, cardText, manaCost, isLegendary, colorIdentity)
    {
        _power = power;
        _toughness = toughness;

        _cardType = "Creature";
    }

    public override int GetPower()
    {
        return _power;
    }

    public override void TakeDamage(int damage)
    {
        if (damage >= _toughness)
        {
            Console.WriteLine($"{_name} died!");
        }
        else
        {
            Console.WriteLine($"{_name} survived the attack!");
        }
    }
    public override string GetCardInfo()
    {

        string info = base.GetCardInfo() + $"\nPower: {_power}\nToughness: {_toughness}";
        return info;
    }
}