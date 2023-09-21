using Program;

namespace blackjackApp;

public class DeckHandler{
    private List<Card> _deck = new List<Card>();
    private Stack<Card> myStack = new Stack<Card>();
    private List<Card> discardPile = new List<Card>();
    private int initialDeckLengthINT;
    

    public void makeDeck(int NrOfDecks = 1)
    {
        for (int i = 0; i < NrOfDecks; i++)
        {
            foreach (var name in Enum.GetNames<CardSymbol>())
            {
                //Console.WriteLine(name);
                foreach (var value in Enum.GetNames<CardValue>())
                {
                    _deck.Add(new Card(name, value));
                }
            }
        }
        Console.WriteLine(NrOfDecks + " has been added");
        Console.WriteLine(_deck.Count + " amount of cards");
        initialDeckLengthINT = _deck.Count;
    }

    public Card drawCard()
    {
        
        Card drawnCard = myStack.Pop();
        discardPile.Add(drawnCard);
        if (myStack.Count == 0)
        {
            Console.WriteLine("DECK IS EMPTY ADDING CARD FROM DISCARD PILE AND ReSHUFFLING");
            RemakeDeckIfDeckIsEmpty();
            discardPile.Clear();
        }

        if (discardPile.Count == 52)
        {
            Console.WriteLine("52 cards in discard pile");
        }
        return drawnCard;
    }

    public int deckLength()
    {
        return myStack.Count;
    }

    public int initialDeckLength()
    {
        return initialDeckLengthINT;
    }

    public void RemakeDeckIfDeckIsEmpty()
    {
        //Console.WriteLine(myStack.Count + "before stack clear");
        myStack.Clear();
        _deck.Clear();
        foreach (var card in discardPile)
        { ;
            _deck.Add(card);
            
        }
        shuffleDeck();
    }
    

    public void printDeck()
    {
        foreach (var card in myStack)
        {
            Console.WriteLine(card.ToString());
        }
    }

    public void printDiscardPile()
    {
        foreach (var card in discardPile)
        {
            Console.WriteLine(card.ToString());
        }
    }

    public void shuffleDeck()
    {
        var Random = new Random();
        var newShuffleList = new List<Card>();
        var listlength = _deck.Count;
        for (int i = 0; i < listlength; i++)
        {
            var randomElementInList = Random.Next(0, _deck.Count);
            newShuffleList.Add(_deck[randomElementInList]);
            _deck.Remove(_deck[randomElementInList]);
        }

        _deck = newShuffleList;
        for (int i = 0; i < _deck.Count; i++)
        {
            myStack.Push(newShuffleList[i]);
            //Console.WriteLine(myStack.Count);
        }
    }
}