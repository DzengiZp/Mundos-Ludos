namespace GruppUppgift2.GameMenu
{
    public class GameMenus
    {
        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Type 'help' to learn about the game or '3' to exit.");
                Console.WriteLine("""
                   ╔═════════════════════════════════════════════════╗
                   ║ ╦ ╦╔═╗╦  ╔═╗╔═╗╔╦╗╔═╗  ╔╦╗╔═╗  ╦╔═╔═╗╦ ╦╦       ║
                   ║ ║║║║╣ ║  ║  ║ ║║║║║╣    ║ ║ ║  ╠╩╗╠═╣║ ║║       ║
                   ║ ╚╩╝╚═╝╩═╝╚═╝╚═╝╩ ╩╚═╝   ╩ ╚═╝  ╩ ╩╩ ╩╩╚╝╩       ║
                   ║ ┌─┐┌─┐┬  ┌─┐┌─┐┌┬┐  ┌─┐┌─┐┌┬┐┌─┐  ┌┬┐┌─┐┌┬┐┌─┐  ║
                   ║ └─┐├┤ │  ├┤ │   │   │ ┬├─┤│││├┤   ││││ │ ││├┤   ║
                   ║ └─┘└─┘┴─┘└─┘└─┘ ┴   └─┘┴ ┴┴ ┴└─┘  ┴ ┴└─┘─┴┘└─┘  ║
                   ║ ┌─┐┬  ┌─┐┬ ┬┌─┐┬─┐  ┬  ┬┌─┐  ┌─┐┬  ┌─┐┬ ┬┌─┐┬─┐ ║
                1. ║ ├─┘│  ├─┤└┬┘├┤ ├┬┘  └┐┌┘└─┐  ├─┘│  ├─┤└┬┘├┤ ├┬┘ ║
                   ║ ┴  ┴─┘┴ ┴ ┴ └─┘┴└─   └┘ └─┘  ┴  ┴─┘┴ ┴ ┴ └─┘┴└─ ║
                   ║ ┌─┐┬  ┌─┐┬ ┬┌─┐┬─┐  ┬  ┬┌─┐  ┌─┐┌─┐┬ ┬          ║
                2. ║ ├─┘│  ├─┤└┬┘├┤ ├┬┘  └┐┌┘└─┐  │  ├─┘│ │          ║
                   ║ ┴  ┴─┘┴ ┴ ┴ └─┘┴└─   └┘ └─┘  └─┘┴  └─┘          ║
                   ╚═════════════════════════════════════════════════╝   
                """);

                Console.Write("Select game mode: ");

                string option = Console.ReadLine()!.ToLower();

                switch (option)
                {
                    case "1":
                        StartPvPGame();
                        break;
                    case "2":
                        StartPvCpuGame();
                        break;
                    case "3":
                        return;
                    default:
                        if (option.Contains("help"))
                        {
                            HelpInfo();
                        }
                        else
                        {
                            if (string.IsNullOrWhiteSpace(option))
                            {
                                Console.WriteLine("\nInput can't be empty, please select one of the options.");
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid input, please select one of the available game modes. ");
                            }
                            Console.Write("\nPress any key to continue ");
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }

        private static void StartPvPGame()
        {
            string player1Name = GetValidPlayerName("\nEnter name for Player 1: ");
            string player2Name = GetValidPlayerName("\nEnter name for Player 2: ");

            Player player1 = new Player(player1Name);
            Player player2 = new Player(player2Name);

            Console.WriteLine($"\n=====// {player1.Name} versus {player2.Name} \\\\=====\n");
            Console.Write("Press any key to continue ");
            Console.ReadKey();


            Game game = new Game(player1, player2);
            game.StartPlayerVsPlayer();
        }

        private static void StartPvCpuGame()
        {
            string player1Name = GetValidPlayerName("\nEnter name for Player 1: ");

            Player player1 = new(player1Name);

            Random random = new();
            List<string> names = Player.GetPeopleNames();
            string computerName = names[random.Next(names.Count)];

            Player computerPlayer = new(computerName);

            Console.WriteLine($"\n====// {player1.Name} versus {computerName}(CPU) \\\\====\n");
            Console.Write("Press any key to continue ");
            Console.ReadKey();

            Game game = new Game(player1, computerName);
            game.StartPlayerVsComputer();
        }

        public static string GetValidPlayerName(string prompt)
        {
            string playerName = string.Empty;
            while (string.IsNullOrWhiteSpace(playerName))
            {
                Console.Write(prompt);
                playerName = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(playerName))
                {
                    Console.WriteLine("\nName cannot be empty, please enter a valid name ");
                }
            }
            return playerName;
        }

        public static void HelpInfo()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mundos Ludos Kaiji game!\n");
            Console.WriteLine("If you at any point in the game when choosing a card want to exit the game, press the ESC button.\n");
            Console.WriteLine("Guide:\n");
            Console.WriteLine("[Game Modes]\n");
            Console.WriteLine("Player vs Player (PvP): Two players compete against each other.");
            Console.WriteLine("Player vs Computer (PvC): A player competes against the computer.\n");
            Console.WriteLine("[How to Play]\n");
            Console.WriteLine("Start the Game: Choose your game mode from the menu.\n");
            Console.WriteLine("Enter Player Names: If you're playing PvP, both players will enter their names.");
            Console.WriteLine("If you’re playing PvC mode, you'll enter your name, and the computer will have a random name.\n");
            Console.WriteLine("Card Types: There are three types of cards - Emperor, Citizen, and Slave. Each card has a specific role:\n");
            Console.WriteLine("->> Emperor beats Citizen.");
            Console.WriteLine("->> Citizen beats Slave.");
            Console.WriteLine("->> Slave beats Emperor.\n");
            Console.WriteLine("Playing a Match: Players will take turns choosing a card from their hand to play against their opponent up to 5 matches.\n");
            Console.WriteLine("Winning a Match: The player whose card wins the match gets a point. If the cards are the same, it's a draw.\n");
            Console.WriteLine("Game Rounds: The game consists of 12 rounds where each player will draw and play cards.\n");
            Console.WriteLine("Determining the Winner: After all rounds are played, the player with the most points wins the game.\n");
            Console.WriteLine("Help: If you need to see the help again, you can type in 'help' in the menu.\n");
            Console.WriteLine("Enjoy playing Kaiji and may the best player win!\n");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }
    }
}