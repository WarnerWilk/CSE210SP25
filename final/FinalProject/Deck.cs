class Deck
{
    List<Card> _cards = [];
    Random rand = new Random();
    public void NewCard()
    {
        Console.Write("Enter card type (e.g. Creature, Mana Dork, Mana Rock, Vehicle, Land): ");
        string cardType = Console.ReadLine();

        switch (cardType)
        {
            case "Creature":
                Creature creature = new Creature();
                creature.CreateCard();
                _cards.Add(creature);
                break;

            case "Mana Dork":
                ManaDork manaDork = new ManaDork();
                manaDork.CreateCard();
                _cards.Add(manaDork);
                break;

            case "Mana Rock":
                ManaRock manaRock = new ManaRock();
                manaRock.CreateCard();
                _cards.Add(manaRock);
                break;

            case "Vehicle":
                Vehicle vehicle = new Vehicle();
                vehicle.CreateCard();
                _cards.Add(vehicle);
                break;

            case "Land":
                Land land = new Land();
                land.CreateCard();
                _cards.Add(land);
                break;

            default:
                Console.WriteLine("Unknown card type.");
                break;
        }
    }

    public string GetCardInfo(string cardName)
    {
        string response = "";
        foreach (Card card in _cards)
        {
            if (card.GetCardName() == cardName)
            {
                response = card.GetCardInfo();
            }
            else
            {
                response = "Card not found.";
            }
        }
        return response;
    }

    public void DisplayAllCards()
    {
        foreach (Card card in _cards)
        {
            Console.WriteLine(card.GetCardInfo());
        }
    }
    public string GetRandomCard()
    {
        return _cards[rand.Next()].GetCardInfo();
    }

    public void DefendWithCreature(string cardName, int power)
    {
        foreach (Creature card in _cards)
        {
            if (card.GetCardName() == cardName)
            {
                card.TakeDamage(power);
                break;
            }
        }
        Console.WriteLine("Card not found.");
    }

    public void TapForMana(string cardName)
    {
        foreach (TapsForMana card in _cards)
        {
            if (card.GetCardName() == cardName)
            {
                card.ManaTap();
                break;
            }
        }
        Console.WriteLine("Card not found.");
    }
    public void CrewVehicle(string vehicleName, string creatureName)
    {
        int creaturePower = 0;
        

        foreach (Creature card in _cards)
        {
            if (card.GetCardName() == creatureName)
            {
                creaturePower = card.GetPower();
            }
        }
        
        foreach (Vehicle card in _cards)
        {
            if (card.GetCardName() == vehicleName)
            {
                card.Crew(creaturePower);
            }
        }
    }
}