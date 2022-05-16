public class Card
{
    int card = 5;

    public int newCard()
    {
        card = new Random().Next(1, 14);
        return card;
    }

    public int previousCard()
    {
        return card;
    }
}