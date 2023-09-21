namespace blackjackApp;

public class GameMenu{
    
    

    public void startGame()
    {
        bool gameRunning = true;
        Console.WriteLine("Starting game");
        DeckHandler deck = new DeckHandler();
        Player player = new Player(); 
        Player dealer = new Player();
        deck.makeDeck();
        deck.shuffleDeck();
        while (gameRunning)
        {
            if (player.handValue() >= 21)
            {
                if (player.hasAce())
                {
                }
                Console.WriteLine("HandValue exceeded 21 || " + player.handValue());
                break;
            }

            if (player.EmptyHand())
            {
                player.givePlayerCard(deck.drawCard());
                dealer.givePlayerCard(deck.drawCard());
                player.givePlayerCard(deck.drawCard());
                dealer.givePlayerCard(deck.drawCard());
            }

            bool choiceMade = false; 
            
            Console.WriteLine("Hit or Stand?");
            string answer = Console.ReadLine();
            
            if (answer.ToLower() == "hit")
            {
                Console.WriteLine("HIT!");
                player.givePlayerCard(deck.drawCard());
                Console.WriteLine("Current hand value : " + player.handValue());
            }

            if (answer.ToLower() == "stand")
            {
                Console.WriteLine("Stand");
                
            }

        } ;

    }
}