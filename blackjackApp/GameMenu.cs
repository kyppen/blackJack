namespace blackjackApp;

public class GameMenu{
    
    

    public void startGame()
    {
        bool gameRunning = true;
        Console.WriteLine("Starting game");
        while (gameRunning)
        {
            DeckHandler deck = new DeckHandler();
            Player player = new Player();
            deck.makeDeck();
            deck.shuffleDeck();
            if (player.handValue() >= 21)
            {
                gameRunning = false;
                Console.WriteLine("HandValue exceeded 21 " + player.handValue());
            }

            if (player.EmptyHand())
            {
                player.givePlayerCard(deck.drawCard());
                player.givePlayerCard(deck.drawCard());
            }

            bool choiceMade = false; 
            
            Console.WriteLine("Give me input");
            string answer = Console.ReadLine();
            Console.WriteLine(answer);
            if (answer.ToLower() == "hit")
            {
                Console.WriteLine("HIT!");
            }

            if (answer.ToLower() == "stand")
            {
                Console.WriteLine("Stand");
            }

        } ;

    }
}