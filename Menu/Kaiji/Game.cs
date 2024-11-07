public class Game
{
    private readonly Player player1 = null!;
    private readonly Player player2 = null!;
    public int player1Points = 0;
    public int player2Points = 0;
    private readonly string computerName = null!;
    private bool exitGame = false;

    public Game(Player p1, Player p2)
    {
        player1 = p1;
        player2 = p2;
    }

    public Game(Player p1, string computerName)
    {
        player1 = p1;
        player2 = new Player(computerName);
        this.computerName = computerName;
    }

    public void StartPlayerVsPlayer()
    {
        Console.Clear();
        Console.WriteLine($"     {{{player1.Name}}} vs {{{player2.Name}}}\n");

        for (int i = 0; i < 3; i++)
        {
            SetupInitialCards(true);
            PlayMatchPvp();
        }

        for (int i = 0; i < 3; i++)
        {
            SetupInitialCards(false);
            PlayMatchPvp();
        }

        for (int i = 0; i < 3; i++)
        {
            SetupInitialCards(true);
            PlayMatchPvp();
        }

        for (int i = 0; i < 3; i++)
        {
            SetupInitialCards(false);
            PlayMatchPvp();
        }

        DetermineWinner();
    }

    public void PlayMatchPvp()
    {
        Console.Clear();
        Console.WriteLine($"     {{{player1.Name}}} vs {{{player2.Name}}}\n");

        Random random = new Random();
        int fight = 1;

        for (int match = 0; match < 5; match++)
        {
            if (exitGame) return;

            Console.WriteLine($"         -- Match {fight} -- \n");

            List<Card> shuffledHand1 = new List<Card>();
            while (player1.Hand.Count > 0)
            {
                int cardNumber = random.Next(player1.Hand.Count);
                shuffledHand1.Add(player1.Hand[cardNumber]);
                player1.Hand.RemoveAt(cardNumber);
            }
            player1.Hand = shuffledHand1;

            List<Card> shuffledHand2 = new List<Card>();
            while (player2.Hand.Count > 0)
            {
                int cardNumber = random.Next(player2.Hand.Count);
                shuffledHand2.Add(player2.Hand[cardNumber]);
                player2.Hand.RemoveAt(cardNumber);
            }
            player2.Hand = shuffledHand2;

            Console.WriteLine($"{player1.Name}, choose a card:\n");
            for (int i = 0; i < player1.Hand.Count; i++)
            {
                Console.WriteLine($"{i}: {player1.Hand[i].Name}");
            }

            int p1CardChoice = CheckPlayerCard(player1.Hand.Count, ref exitGame);
            if (exitGame) return;

            Console.WriteLine($"\n{player2.Name}, choose a card:\n");
            for (int i = 0; i < player2.Hand.Count; i++)
            {
                Console.WriteLine($"{i}: {player2.Hand[i].Name}");
            }

            int p2CardChoice = CheckPlayerCard(player2.Hand.Count, ref exitGame);
            if (exitGame) return;

            Card p1Card = player1.PlayCard(p1CardChoice)!;
            Card p2Card = player2.PlayCard(p2CardChoice)!;

            Console.WriteLine("\n============================");
            Console.WriteLine("\nAn intense battle has begun...\n");

            bool matchWon = DetermineMatchWinner(p1Card, p2Card);

            if (matchWon)
            {
                break;
            }

            fight++;
        }
    }

    public void StartPlayerVsComputer()
    {
        Console.Clear();
        Console.WriteLine($"     {{{player1.Name}}} vs {{{computerName}}}(CPU)\n");

        for (int i = 0; i < 3; i++)
        {
            SetupInitialCards(true);
            PlayMatchCpu();
        }

        for (int i = 0; i < 3; i++)
        {
            SetupInitialCards(false);
            PlayMatchCpu();
        }

        for (int i = 0; i < 3; i++)
        {
            SetupInitialCards(true);
            PlayMatchCpu();
        }

        for (int i = 0; i < 3; i++)
        {
            SetupInitialCards(false);
            PlayMatchCpu();
        }

        DetermineWinner();
    }

    public void PlayMatchCpu()
    {
        Console.Clear();
        Console.WriteLine($"     {{{player1.Name}}} vs {{{computerName}}}(CPU)\n");

        Random random = new();
        int fight = 1;

        for (int match = 0; match < 5; match++)
        {
            if (exitGame) return;

            Console.WriteLine($"         -- Match {fight} -- \n");

            List<Card> shuffledHand1 = new List<Card>();
            while (player1.Hand.Count > 0)
            {
                int index = random.Next(player1.Hand.Count);
                shuffledHand1.Add(player1.Hand[index]);
                player1.Hand.RemoveAt(index);
            }
            player1.Hand = shuffledHand1;

            Console.WriteLine($"{player1.Name}, choose a card:\n");

            for (int i = 0; i < player1.Hand.Count; i++)
            {
                Console.WriteLine($"{i}: {player1.Hand[i].Name}");
            }

            int p1CardChoice = CheckPlayerCard(player1.Hand.Count, ref exitGame);
            if (exitGame) return;

            int p2CardChoice = random.Next(0, player2.Hand.Count);

            Card p1Card = player1.PlayCard(p1CardChoice)!;
            Card p2Card = player2.PlayCard(p2CardChoice)!;

            Console.WriteLine("\n============================");
            Console.WriteLine("\nAn intense battle has begun...\n");

            bool matchWon = DetermineMatchWinner(p1Card, p2Card);

            if (matchWon)
            {
                break;
            }

            fight++;
        }
    }

    public bool DetermineMatchWinner(Card p1Card, Card p2Card)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"{{{player1.Name}}} played [{p1Card.Name}]");
        Thread.Sleep(1000);
        Console.WriteLine($"{{{player2.Name}}} played [{p2Card.Name}]");
        Thread.Sleep(1000);

        if (p1Card.Name == CardName.Emperor && p2Card.Name == CardName.Citizen ||
            p1Card.Name == CardName.Citizen && p2Card.Name == CardName.Slave ||
            p1Card.Name == CardName.Slave && p2Card.Name == CardName.Emperor)
        {
            Console.WriteLine($"\n***** {{{player1.Name}}} wins the match! *****");
            player1Points += 1;
            Console.Write("\nPress any key to start the next match ");
            Console.ReadKey();
            return true;
        }
        else if (p2Card.Name == CardName.Emperor && p1Card.Name == CardName.Citizen ||
                 p2Card.Name == CardName.Citizen && p1Card.Name == CardName.Slave ||
                 p2Card.Name == CardName.Slave && p1Card.Name == CardName.Emperor)
        {
            Console.WriteLine($"\n***** {{{player2.Name}}} wins the match! *****");
            player2Points += 1;
            Console.Write("\nPress any key to start the next match ");
            Console.ReadKey();
            Console.Clear();
            return true;
        }
        else
        {
            Console.WriteLine("\n***** The battle has concluded in a draw! *****");
            Console.Write("\nPress any key to start the next match ");
            Console.ReadKey();
            Console.Clear();
            return false;
        }
    }

    public void DetermineWinner()
    {
        Console.Clear();
        Console.WriteLine("\n========================================\n");
        Console.WriteLine("    Game over. Thanks for playing!\n");
        Console.WriteLine($@"       |____/ SCOREBOARD \____|
     {{{player1.Name}}} - [{player1Points}] || {{{player2.Name}}} - [{player2Points}]");

        if (player1Points > player2Points)
        {
            Console.WriteLine($"\n***** {{{player1.Name}}} is the winner, and gets to live to fight another day! *****");
        }
        else if (player2Points > player1Points)
        {
            Console.WriteLine($"\n***** {{{player2.Name}}} is the winner, and gets to live to fight another day! *****");
        }
        else
        {
            Console.WriteLine("\n***** It's a draw! Both get to live to fight another day *****\n");
        }

        Console.WriteLine("======================================== \n");
        Console.Write("Press any key to back to the start menu");
        Console.ReadKey();
    }

    public void SetupInitialCards(bool isPlayer1Emperor)
    {
        player1.Hand.Clear();
        player2.Hand.Clear();

        if (isPlayer1Emperor)
        {
            player1.AddCardToHand(new Card(CardName.Citizen));
            player1.AddCardToHand(new Card(CardName.Citizen));
            player1.AddCardToHand(new Card(CardName.Citizen));
            player1.AddCardToHand(new Card(CardName.Citizen));
            player1.AddCardToHand(new Card(CardName.Emperor));

            player2.AddCardToHand(new Card(CardName.Citizen));
            player2.AddCardToHand(new Card(CardName.Citizen));
            player2.AddCardToHand(new Card(CardName.Citizen));
            player2.AddCardToHand(new Card(CardName.Citizen));
            player2.AddCardToHand(new Card(CardName.Slave));
        }
        else
        {
            player1.AddCardToHand(new Card(CardName.Citizen));
            player1.AddCardToHand(new Card(CardName.Citizen));
            player1.AddCardToHand(new Card(CardName.Citizen));
            player1.AddCardToHand(new Card(CardName.Citizen));
            player1.AddCardToHand(new Card(CardName.Slave));

            player2.AddCardToHand(new Card(CardName.Citizen));
            player2.AddCardToHand(new Card(CardName.Citizen));
            player2.AddCardToHand(new Card(CardName.Citizen));
            player2.AddCardToHand(new Card(CardName.Citizen));
            player2.AddCardToHand(new Card(CardName.Emperor));
        }
    }

    public static int CheckPlayerCard(int handCount, ref bool exitGame)
    {
        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                exitGame = true;
                return -1;
            }
            if (int.TryParse(keyInfo.KeyChar.ToString(), out int index) && index >= 0 && index < handCount)
            {
                Console.Write(" ");
                return index;
            }
            Console.WriteLine("\nPlease select an existing card.");
        }
    }

}