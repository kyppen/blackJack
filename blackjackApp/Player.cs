using Program;

namespace blackjackApp;

public class Player{
    private List<Card> _hand = new List<Card>();

    public bool EmptyHand()
    {
        if (_hand.Count == 0)
        {
            return true;
        }

        return false;
    }


    public void givePlayerCard(Card card)
    {
        Console.WriteLine("Card drawn: " + card.ToString());
        _hand.Add(card);
    }

    public void clearPlayerHand()
    {
        _hand.Clear();
    }

    public int handValue()
    {
        int total = 0;
        foreach (var card in _hand)
        {
            {
                total += card.getValue();
            }

        }

        return total;
    }
}