public class Player
{
    public string Name { get; } = null!;
    public List<Card> Hand { get; set; } = null!;

    public Player(string name)
    {
        Name = name;
        Hand = new List<Card>();
    }

    public void AddCardToHand(Card card)
    {
        Hand.Add(card);
    }

    public Card? PlayCard(int index)
    {
        if (index < 0 || index >= Hand.Count)
        {
            return null;
        }

        Card playedCard = Hand[index];
        Hand.RemoveAt(index);
        return playedCard;
    }

    //Can also be an enum.
    public static List<string> GetPeopleNames()
    {
        return new List<string>
        {
            "William",
            "Tony",
            "Gustav",
            "Martin",
            "Nour",
            "Aras",
            "Elias",
            "Adrian",
            "Josef",
            "Ebad",
            "Matthias",
            "Zana",
            "Lejli",
            "Elon Musk",
            "Donald Trump",
            "Jimmy",
            "Joe Rogan"
        };
    }
}