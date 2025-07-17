using Microsoft.VisualBasic;

class Creature : Card
{
    protected int _power = 0;
    protected int _toughness = 0;
    
    public Creature(string name, string cardText, List<int> manaCost, bool isLegendary, string colorIdentity, int power, int toughness) :
    base(name, cardText, manaCost, isLegendary, colorIdentity)
    {
        _power = power;
        _toughness = toughness;

        if (isLegendary == false)
        {
            _cardType = "Creature";
        }
        else
        {
            _cardType = "Legendary Creature";
        }
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