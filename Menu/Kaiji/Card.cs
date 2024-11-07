public class Card
{
    public CardName Name { get; set; }
    public Card(CardName name)
    {
        Name = name;
    }
}

public enum CardName
{
    Emperor,
    Citizen,
    Slave
}