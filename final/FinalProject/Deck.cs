class Deck
{
    List<Card> _cards = [];

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

    public void DisplayAllCards()
    {
        foreach (Card card in _cards)
        {
            Console.WriteLine(card.GetCardInfo());
        }
    }
}