using System;
using GruppUppgift2;
using GruppUppgift2.GameMenu;
using Menu.DekrimFolder;
using warmonsterclass;

public class Program
{
    static TextColor currentColor = TextColor.Default;

    public static void Main(string[] args)
    {
        StoryMode story = new();
        story.StartStory();

        bool running = true;

        while (running)
        {
            Console.Clear(); ;
            DisplayMainMenu();
            ApplyTextColor();
            Console.Write("\nPlease choose an option: ");
            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    DisplayGames();
                    break;
                case "2":
                    OpenSettings();
                    break;
                case "3":
                    DisplayHelp();
                    break;
                case "4":
                    Console.WriteLine("Exiting ");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }

    public static void DisplayMainMenu()
    {
        ApplyTextColor();
        Console.WriteLine("##############################################");
        Console.WriteLine("#                                            #");
        Console.WriteLine("#          WELCOME TO MUNDOS LUNDOS          #");
        Console.WriteLine("#                                            #");
        Console.WriteLine("##############################################");
        Console.WriteLine("#                                            #");
        Console.WriteLine("# 1. Start                                   #");
        Console.WriteLine("# 2. Settings                                #");
        Console.WriteLine("# 3. Help                                    #");
        Console.WriteLine("# 4. Exit                                    #");
        Console.WriteLine("#                                            #");
        Console.WriteLine("##############################################");
        Console.ResetColor();
    }

    static void DisplayGames()
    {
        Console.Clear();
        ApplyTextColor();
        Console.WriteLine("##############################################");
        Console.WriteLine("#               GAME SELECTION               #");
        Console.WriteLine("##############################################");
        Console.WriteLine("#                                            #");
        Console.WriteLine("#                 1. Kaiji                   #");
        Console.WriteLine("#                                            #");
        Console.WriteLine("##############################################");
        Console.WriteLine("#                                            #");
        Console.WriteLine("#                 2. Warmonster              #");
        Console.WriteLine("#                                            #");
        Console.WriteLine("##############################################");
        Console.WriteLine("#                                            #");
        Console.WriteLine("#                 3. Dekrim                  #");
        Console.WriteLine("#                                            #");
        Console.WriteLine("##############################################");
        Console.Write("\nSelect an option: ");

        string option = Console.ReadLine()!;

        if (option.Equals("1"))
        {
            Console.Clear();
            GameMenus.Menu();
        }
        else if (option.Equals("2"))
        {
            Console.Clear();
            WarMonster.PlayWarMonster();
        }
        else if (option.Equals("3"))
        {
            Console.Clear();
            Console.WriteLine("Dekrim");
            Dekrim.DekrimStart();
        }
        else
        {
            Console.WriteLine("Invalid choice, returning to Main Menu.");
        }
        Console.ResetColor();
    }

    static void OpenSettings()
    {
        Console.Clear();
        ApplyTextColor();
        Console.WriteLine("Settings:\n");
        Console.WriteLine("1. Change Text Color");
        Console.WriteLine("2. Back to Main Menu\n");
        Console.Write("Choose an option: ");
        string choice = Console.ReadLine()!;

        if (choice == "1")
        {
            ChangeTextColor();
        }
        else if (choice != "2")
        {
            Console.WriteLine("Invalid option, returning to Settings.");
        }
    }

    static void ChangeTextColor()
    {
        Console.Clear();
        ApplyTextColor();
        Console.WriteLine("Choose a color:");
        Console.WriteLine("1. Red");
        Console.WriteLine("2. Green");
        Console.WriteLine("3. Blue");
        Console.WriteLine("4. Default");

        Console.Write("Enter the color number: ");
        string colorChoice = Console.ReadLine()!;

        switch (colorChoice)
        {
            case "1":
                currentColor = TextColor.Red;
                break;
            case "2":
                currentColor = TextColor.Green;
                break;
            case "3":
                currentColor = TextColor.Blue;
                break;
            case "4":
                currentColor = TextColor.Default;
                break;
            default:
                Console.WriteLine("\nInvalid color choice, setting to Default.");
                currentColor = TextColor.Default;
                break;
        }
        Console.WriteLine("\nText color updated!");
        Console.ReadKey();
    }

    static void DisplayHelp()
    {
        Console.Clear();
        ApplyTextColor();

        Console.WriteLine("=###= Help Menu =###=\n");
        Console.WriteLine("1. Kaji E-Card: ");
        Console.WriteLine("2. Warmonster: ");
        Console.WriteLine("3. Dekrim: ");
        Console.WriteLine("4. Exit");

        var key = Console.ReadKey(true).Key;
        switch (key)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                KaijiHelp();
                break;
            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
                WarmonsterHelp();
                break;
            case ConsoleKey.D3:
            case ConsoleKey.NumPad3:
                DekrimHelp();
                break;
            default:
                Console.WriteLine("Invalid choice, try again.");
                Console.ReadKey();
                break;
        }
    }

    static void WarmonsterHelp()
    {
        ApplyTextColor();
        Console.Clear();
        Console.WriteLine("#          📝 Instructions: How to Play 📝         ");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("[1] Fight rats and mini monsters to gain levels.");
        Console.WriteLine("[2] Reach level 3 to fight bigger monsters.");
        Console.WriteLine("[3] At level 5, you can challenge the Final Boss!");
        Console.WriteLine("[4] - If you lose you're weapon you can't fight the finalboss!");
        Console.WriteLine("[5] View experience points to track progress.");
        Console.WriteLine($"\n             Good luck! 🏆  ");
        Console.ReadKey();
    }

    static void DekrimHelp()
    {
        ApplyTextColor();
        Console.Clear();
        Console.WriteLine("=###= Dekrim Help Menu =###=\n");
        Console.WriteLine("You are the CEO, competing with corporate giants. Make wise investments, buy/sell products, and take risks to reach the top.");
        Console.WriteLine("Earn 100 Legacy Points to unlock 'Last Dance,' a final 50/50 battle against Elon Musk to claim world’s richest title!\n");

        Console.WriteLine("Game Modes and Challenges:");
        Console.WriteLine("1. Buy and Sell Products:");
        Console.WriteLine("   - Buy products to build inventory at low prices, then sell high to increase profit.");
        Console.WriteLine("   - Each product has a distinct buy/sell price. Track market trends and balance supply.\n");

        Console.WriteLine("2. Sabotage Competitors:");
        Console.WriteLine("   - Pay 1 million to sabotage competitors, potentially gaining 10 million, employees, and product stocks.");
        Console.WriteLine("   - Success depends on your resources compared to theirs:");
        Console.WriteLine("   - 80% chance if your resources match or exceed theirs.");
        Console.WriteLine("   - 50% if close; 20% if below their level.");
        Console.WriteLine("   - Risk: Losing the investment and potential jail time if sabotage fails.\n");

        Console.WriteLine("3. Tax Fraud:");
        Console.WriteLine("   - High-risk, 70% success gamble to gain funds quickly.");
        Console.WriteLine("   - Fail, and you face jail time and temporary setbacks.\n");

        Console.WriteLine("4. Company vs. Company:");
        Console.WriteLine("   - Compete against another company in a 70% success rate battle to increase funds and status.");
        Console.WriteLine("   - Risk: Losing resources if unsuccessful.\n");

        Console.WriteLine("5. Last Dance:");
        Console.WriteLine("   - Final 50/50 battle with Elon Musk. Victory brings ultimate wealth and legacy. Defeat, however, resets your progress.\n");

        Console.WriteLine("- Don't lose track of your stats! ");
        Console.WriteLine("- Legacy Points: Earned through challenges; required to unlock Last Dance.");
        Console.WriteLine("- Jail Time: Failed Tax Fraud or Sabotage may result in jail, pausing your actions temporarily.\n");
        Console.WriteLine("Press any key to return to the menu");
        Console.ReadKey();

    }

    static void KaijiHelp()
    {
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
    static void ApplyTextColor()
    {
        switch (currentColor)
        {
            case TextColor.Red:
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case TextColor.Green:
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            case TextColor.Blue:
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            default:
                Console.ResetColor();
                break;
        }
    }
}

enum TextColor
{
    Default,
    Red,
    Green,
    Blue
};