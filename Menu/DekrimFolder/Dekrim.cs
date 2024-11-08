using System.Media;

namespace Menu.DekrimFolder
{
    public static class Dekrim
    {
        static Company company = null!;
        static int jailCounter = 0;
        public static void DekrimStart()
        {
            company = new Company("Your Company", 10000m, 5);
            WholeGame();
        }

        public static void WholeGame()
        {
            StartGame();
            AfterStart();
            ShowMenu();
        }

        public static void StartGame()
        {
            Console.WriteLine("Press 'M' to start the game...");

            while (true)
            {
                var key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.M)
                {
                    Console.Clear();
                    Console.WriteLine("Game starting...");


                    BlinkingText blinker = new BlinkingText();
                    blinker.DisplayEffect(@"Welcome to Dekrim! Welcome to Dekrim!

Welcome to Dekrim! Welcome to Dekrim!

Welcome to Dekrim! Welcome to Dekrim!", 5000, 500);


                    Console.WriteLine("Press any key to continue!");
                    Console.ReadKey();
                    Console.Clear();

                    break;



                }
            }


        }

        public static void AfterStart()
        {
            string companyName;
            do
            {
                Console.WriteLine("Create a name for your company: ");
                companyName = Console.ReadLine()!.Trim();
                if (string.IsNullOrEmpty(companyName))
                {
                    Console.Clear();
                    Console.WriteLine("Company name cannot be empty. Please enter a valid name.");
                }
            } while (string.IsNullOrEmpty(companyName));

            Console.Clear();
            Console.WriteLine($"The name of your company is {companyName}!");
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You start with\n10.000£\n5 Employees\n0 Products");
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }



        public static void ShowMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("----- MENU -----");
                Console.WriteLine("1. Stats");
                Console.WriteLine("2. Buy");
                Console.WriteLine("3. Sell");
                Console.WriteLine("4. Sabotage");
                Console.WriteLine("5. Tax Fraud");
                Console.WriteLine("6. Company vs Company");
                Console.WriteLine("7. Last Dance");
                Console.WriteLine("8. ~Help~");
                Console.WriteLine("9. Exit");
                Console.WriteLine("Select an option (1-9): ");

                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        ShowStats();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Buy();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Sell(company);
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Sabotage(company);
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        TaxFraud(company);
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        ChooseChallenge();
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        LastDance(company);
                        break;
                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        HelpMenu();
                        break;
                    case ConsoleKey.D9:
                    case ConsoleKey.NumPad9:
                        return;
                    default:
                        Console.ReadKey();
                        Console.WriteLine("Invalid selection. Try again.");
                        break;
                }
            }
        }

        public static void ShowStats()
        {
            Console.Clear();
            Console.WriteLine("----- COMPANY STATS -----");
            Console.WriteLine($"Money: {company.Money}£");
            Console.WriteLine($"Employees: {company.Employees}");

            int totalProducts = company.Products.Sum(p => p.Value);
            Console.WriteLine($"Total Products: {totalProducts}");

            Console.WriteLine("\nProduct Breakdown:");
            foreach (var product in company.Products)
            {
                Console.WriteLine($"{product.Key}: {product.Value} units");
            }

            DisplayStats(company);
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }


        public static void Buy()
        {
            Console.Clear();
            Console.WriteLine("----- Buy Menu -----");
            Console.WriteLine("1. Dairy");
            Console.WriteLine("2. Medicine");
            Console.WriteLine("3. Cars");
            Console.WriteLine("4. Real Estate");
            Console.WriteLine("5. Return to Menu");
            Console.WriteLine("Select a category (1-4): ");

            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.D1:
                    BuyDairy();
                    break;
                case ConsoleKey.D2:
                    BuyMedicine();
                    break;
                case ConsoleKey.D3:
                    BuyCars();
                    break;
                case ConsoleKey.D4:
                    BuyRealEstate();
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    ShowMenu();
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }

        public static void BuyDairy()
        {
            Console.Clear();
            Console.WriteLine("Dairy Products:");
            Console.WriteLine("1. Milk (1£)");
            Console.WriteLine("2. Butter (2£)");
            Console.WriteLine("3. Cheese (7£)");
            Console.WriteLine("4. Return to Menu");
            Console.WriteLine("Select a product (1-3): ");

            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.D1:
                    ProcessPurchase(new DairyProduct("Milk", 1, 1m, 2m));
                    break;
                case ConsoleKey.D2:
                    ProcessPurchase(new DairyProduct("Butter", 1, 2m, 5m));
                    break;
                case ConsoleKey.D3:
                    ProcessPurchase(new DairyProduct("Cheese", 1, 7m, 15m));
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    ShowMenu();
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    Console.ReadKey();
                    break;
            }
        }

        public static void BuyMedicine()
        {
            Console.Clear();
            Console.WriteLine("Medicine Products:");
            Console.WriteLine("1. Paracetamol (2£)");
            Console.WriteLine("2. Oxycodine (5£)");
            Console.WriteLine("3. Omeprazol (10£)");
            Console.WriteLine("4. Ozempic (50£)");
            Console.WriteLine("5. Return to Menu");
            Console.WriteLine("Select a product (1-4): ");

            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.D1:
                    ProcessPurchase(new MedicineProduct("Paracetamol", 1, 2m, 3m));
                    break;
                case ConsoleKey.D2:
                    ProcessPurchase(new MedicineProduct("Oxycodine", 1, 5m, 10m));
                    break;
                case ConsoleKey.D3:
                    ProcessPurchase(new MedicineProduct("Omeprazol", 1, 10m, 15m));
                    break;
                case ConsoleKey.D4:
                    ProcessPurchase(new MedicineProduct("Ozempic", 1, 50m, 100m));
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    ShowMenu();
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }

        public static void BuyCars()
        {
            Console.Clear();
            Console.WriteLine("Car Products:");
            Console.WriteLine("1. Toyota Yaris (10.000£)");
            Console.WriteLine("2. VW Golf (20.000£)");
            Console.WriteLine("3. BMW X6 (50.000£)");
            Console.WriteLine("4. Bugatti Chiron (1.000.000£)");
            Console.WriteLine("5. Return to Menu");
            Console.WriteLine("Select a product (1-4): ");

            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.D1:
                    ProcessPurchase(new CarProduct("Toyota", 1, 10000m, 20000m));
                    break;
                case ConsoleKey.D2:
                    ProcessPurchase(new CarProduct("VW", 1, 20000m, 40000m));
                    break;
                case ConsoleKey.D3:
                    ProcessPurchase(new CarProduct("BMW", 1, 50000m, 100000m));
                    break;
                case ConsoleKey.D4:
                    ProcessPurchase(new CarProduct("Bugatti", 1, 1000000m, 2000000m));
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    ShowMenu();
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }

        public static void BuyRealEstate()
        {
            Console.Clear();
            Console.WriteLine("Real Estate Locations:");
            Console.WriteLine("1. Sweden");
            Console.WriteLine("2. Spain");
            Console.WriteLine("3. US");
            Console.WriteLine("4. Return to Menu");
            Console.WriteLine("Select a country (1-3): ");

            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.D1:
                    BuyInSweden();
                    break;
                case ConsoleKey.D2:
                    BuyInSpain();
                    break;
                case ConsoleKey.D3:
                    BuyInUS();
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    ShowMenu();
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }

        public static void BuyInSweden()
        {
            Console.Clear();
            Console.WriteLine("Sweden Locations:");
            Console.WriteLine("1. Kiruna (100.000£)");
            Console.WriteLine("2. Stockholm (500.000£)");
            Console.WriteLine("3. Return to Real Estate Menu");
            Console.WriteLine("Select a location (1-2): ");

            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.D1:
                    ProcessPurchase(new RealEstateProduct("Kiruna", 1, 100000m, 200000m));
                    break;
                case ConsoleKey.D2:
                    ProcessPurchase(new RealEstateProduct("Stockholm", 1, 500000m, 1000000m));
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    BuyRealEstate();
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }

        public static void BuyInSpain()
        {
            Console.Clear();
            Console.WriteLine("Spain Locations:");
            Console.WriteLine("1. Marbella (2.000.000£)");
            Console.WriteLine("2. Madrid (4.000.000£)");
            Console.WriteLine("3. Barcelona (3.500.000£)");
            Console.WriteLine("4. Return to Real Estate Menu");
            Console.WriteLine("Select a location (1-3): ");

            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.D1:
                    ProcessPurchase(new RealEstateProduct("Marbella", 1, 2000000m, 4000000m));
                    break;
                case ConsoleKey.D2:
                    ProcessPurchase(new RealEstateProduct("Madrid", 1, 4000000m, 8000000m));
                    break;
                case ConsoleKey.D3:
                    ProcessPurchase(new RealEstateProduct("Barcelona", 1, 3500000m, 7000000m));
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    BuyRealEstate();
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }

        public static void BuyInUS()
        {
            Console.Clear();
            Console.WriteLine("US Locations:");
            Console.WriteLine("1. New York (5.000.000£)");
            Console.WriteLine("2. Los Angeles (8.000.000£)");
            Console.WriteLine("3. Return to Real Estate Menu");
            Console.WriteLine("Select a location (1-2): ");

            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.D1:
                    ProcessPurchase(new RealEstateProduct("New York", 1, 5000000m, 1000000m));
                    break;
                case ConsoleKey.D2:
                    ProcessPurchase(new RealEstateProduct("Los Angeles", 1, 8000000m, 1600000m));
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    BuyRealEstate();
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }

        public static void ProcessPurchase(Product product)
        {
            Console.WriteLine($"Enter quantity of {product.Name} to buy:");


            if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0)
            {
                Console.WriteLine("Invalid quantity entered! Please enter a valid number greater than 0.");
                Buy();
                return;
            }

            decimal totalCost = quantity * product.BuyPrice;
            if (company.Money >= totalCost)
            {
                company.SpendMoney(totalCost);


                if (company.Products.ContainsKey(product.Name))
                {
                    company.Products[product.Name] += quantity;
                }
                else
                {
                    company.AddProduct(product.Name, quantity);
                }

                Console.WriteLine($"You bought {quantity} {product.Name}(s) for {totalCost}£.");
                Console.ReadKey();

            }
            else
            {

                Console.WriteLine("Not enough money to buy!");
                Console.ReadKey();
            }
        }

        public static void Sell(Company company)
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Available products:");
                foreach (var product in company.Products)
                {
                    Console.WriteLine($"{product.Key}: {product.Value} units");
                }

                Console.WriteLine("\nEnter product name to sell or type '0' to return to the menu:");
                string productNameInput = Console.ReadLine()!.ToLower();

                if (productNameInput == "0")
                {
                    break;
                }


                string? matchedProductName = null;
                foreach (string productName in company.Products.Keys)
                {
                    if (productName.ToLower() == productNameInput)
                    {
                        matchedProductName = productName;
                        break;
                    }
                }

                if (matchedProductName != null && company.Products.ContainsKey(matchedProductName))
                {
                    Console.WriteLine("Enter quantity to sell: ");
                    if (int.TryParse(Console.ReadLine(), out int quantity))
                    {
                        int availableQuantity = company.Products[matchedProductName];
                        Product product = company.GetProduct(matchedProductName);

                        if (product != null && availableQuantity >= quantity)
                        {
                            decimal totalSale = quantity * product.SellPrice;
                            company.AddMoney(totalSale);
                            company.Products[matchedProductName] -= quantity;

                            if (company.Products[matchedProductName] == 0)
                            {
                                company.Products.Remove(matchedProductName);
                            }

                            Console.WriteLine($"You sold {quantity} {matchedProductName}(s) for {totalSale}£.");
                        }
                        else
                        {
                            Console.WriteLine("Not enough products to sell or invalid input!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid quantity entered!");
                    }
                }
                else
                {
                    Console.WriteLine("Product not found in inventory!");
                }
            }
        }







        public static void ChooseChallenge()
        {
            Console.Clear();
            Console.WriteLine("Press 1. For a Challenge");
            Console.WriteLine("Press 2. Return to Menu");
            Console.WriteLine("----------------------");
            Console.WriteLine("Select an option (1-2): ");

            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.D1:
                    ChallengeCompany(company);
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    ShowMenu();
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }


        public static void ChallengeCompany(Company playerCompany)
        {
            Console.Clear();

            string competitorName = CompetitorCompany.GetRandomCompetitorName();
            CompetitorCompany competitor = new CompetitorCompany(competitorName);

            Console.WriteLine($"You are challenging {competitor.Name} to a 1v1 battle!");

            Random rand = new Random();
            int outcome = rand.Next(1, 101);

            if (outcome <= 70)
            {
                Console.WriteLine("You won the challenge!");
                playerCompany.Money += 1_000_000;
                Console.WriteLine($"You have gained {1_000_000m}£");
                playerCompany.Employees += 50;
                Console.WriteLine($"You have gained {50} Employees");
                Console.WriteLine("------------------------------");

                foreach (var product in playerCompany.Products.Keys.ToList())
                {
                    playerCompany.Products[product] += 1;
                }
            }
            else
            {
                Console.WriteLine("You lost the challenge...");
                Console.WriteLine("You have lost 99% of your money and you are down to 1 employee");
                Console.WriteLine("------------------------------");
                playerCompany.LoseAllExceptMinimum();
                
            }

            Console.WriteLine($"Updated stats:\nMoney: {playerCompany.Money}£\nEmployees: {playerCompany.Employees}");


            CompleteChallenge(playerCompany);

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();




        }

        public static void Sabotage(Company playerCompany)
        {
            Console.Clear();


            string[] competitorNames = { "MickeyD", "VolvOh", "CluckinBell", "Maderna", "Farhoumands mäklarfirma" };


            Console.WriteLine(@"Choose a competitor to sabotage by entering their number or enter ""6"" to return:");
            for (int i = 0; i < competitorNames.Length; i++)
            {

                Console.WriteLine($"{i + 1}. {competitorNames[i]}");
            }


            if (!int.TryParse(Console.ReadLine(), out int selection) || selection < 1 || selection > competitorNames.Length)
            {
                Console.WriteLine("Sabotage aborted.");
                return;
            }

            string selectedCompetitor = competitorNames[selection - 1];
            CompetitorCompany competitor = new CompetitorCompany(selectedCompetitor);
            Console.WriteLine($"You selected {competitor.Name} for sabotage.");

            Random rand = new Random();
            decimal competitorMoney = rand.Next(30, 100) * 1_000_000m;
            int competitorEmployees = rand.Next(500, 2000);
            int competitorProducts = rand.Next(500000, 2000000);

            Console.WriteLine($"{competitor.Name} Stats:");
            Console.WriteLine($"Money: {competitorMoney}£");
            Console.WriteLine($"Employees: {competitorEmployees}");
            Console.WriteLine($"Products: {competitorProducts}");


            if (playerCompany.Money < 1_000_000m)
            {
                Console.Clear();
                Console.WriteLine("You don't have enough money to start sabotage (you need at least 1 million).");
                Console.WriteLine("\nPress any key to return. See you later!");
                Console.ReadKey();
                return;
            }

            playerCompany.Money -= 1_000_000m;

            int totalProducts = GetTotalProductCount(playerCompany);

            bool isClose = playerCompany.Money >= competitorMoney * 0.8m &&
                        playerCompany.Employees >= competitorEmployees * 0.8 &&
                        totalProducts >= competitorProducts * 0.8;

            bool isBetter = playerCompany.Money >= competitorMoney &&
                            playerCompany.Employees >= competitorEmployees &&
                            totalProducts >= competitorProducts;

            int successChance = isBetter ? 80 : isClose ? 50 : 20;

            int roll = rand.Next(1, 101);
            if (roll <= successChance)
            {
                Console.Clear();
                Console.WriteLine("Sabotage successful!");
                playerCompany.Money += 10_000_000m;
                playerCompany.Employees += 100;

                foreach (var product in playerCompany.Products)
                {
                    playerCompany.Products[product.Key] += 10;
                }

                Console.WriteLine("You have gained 10 million, 100 employees, and +10 to each of your product stocks.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sabotage failed... You lost the 1 million investment.");
                StartJailTime();
            }

            CompleteChallenge(playerCompany);

            Console.WriteLine($"Updated stats:\nMoney: {playerCompany.Money}£\nEmployees: {playerCompany.Employees}");
            Console.WriteLine("Press any key to return..");
            Console.ReadKey();

        }

        public static int GetTotalProductCount(Company company)
        {
            int totalProducts = 0;
            foreach (var product in company.Products)
            {
                totalProducts += product.Value;
            }
            return totalProducts;
        }


        public static void StartJailTime()
        {
            jailCounter++;
            int jailDuration = 15 + jailCounter * 5;
            Console.WriteLine($"You are in jail for {jailDuration / 60} minutes and {jailDuration % 60} seconds. No actions can be performed during this time.");

            DateTime jailEnd = DateTime.Now.AddSeconds(jailDuration);
            while (DateTime.Now < jailEnd)
            {
                TimeSpan remaining = jailEnd - DateTime.Now;
                Console.WriteLine($"Jail time remaining: {remaining.Minutes} minutes, {remaining.Seconds} seconds.");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Jail time is over. You can now continue.");
        }



        public static void TaxFraud(Company playerCompany)
        {
            Console.Clear();
            Console.WriteLine("You are about to attempt Tax Fraud.");
            Console.WriteLine("Press 1 to commit Tax Fraud or 2 to back out.");

            string choice = Console.ReadLine()!;

            if (choice == "2")
            {
                Console.WriteLine("You backed out. No action taken.");
                return;
            }
            else if (choice != "1")
            {
                Console.WriteLine("Invalid choice.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Attempting Tax Fraud...");
            Random rand = new Random();
            int outcome = rand.Next(1, 101);

            if (outcome <= 70)
            {
                Console.WriteLine("Tax Fraud succeeded! You gained 10 million.");
                playerCompany.Money += 10_000_000m;
            }
            else
            {
                Console.WriteLine("Tax Fraud failed! You lost 2 million and got jail time.");
                playerCompany.Money -= 2_000_000m;
                StartJailTime();
            }

            CompleteChallenge(playerCompany);
            Console.WriteLine($"Updated Money: {playerCompany.Money}£");
            Console.WriteLine("Press any key to return..");
            Console.ReadKey();

        }

        public static void LastDance(Company playerCompany)
        {
            if (playerCompany.LegacyPoints < 100)
            {
                Console.Clear();
                Console.WriteLine("Insufficient legacy points. You need 100 Legacy points.\nComplete more challenges to unlock the Last Dance.");
                Console.ReadKey();
                return;
            }

            MusicPlay();
            Console.Clear();
            Console.WriteLine("The Last Dance - Final 1v1 against Elon Musk!");
            Console.WriteLine("This will be a 50/50 challenge...");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Random rand = new Random();
            bool playerWins = rand.Next(1, 101) <= 50;

            Console.Clear();
            Console.WriteLine("The epic battle begins...");
            CountdownReveal("Battling Elon Musk...", 3);

            if (playerWins)
            {
                CountdownReveal("You brace yourself as Elon charges forward, throwing every last share of Tesla stock he can muster...\n", 3);
                CountdownReveal("But in a masterstroke of economic wizardry, you turn his assets against him. Wall Street holds its breath.\n", 3);
                CountdownReveal("The world watches as Musk’s net worth plummets like a tech stock in a recession, and your wealth skyrockets.\n", 3);
                CountdownReveal("Congratulatory calls pour in. You've achieved what few dared to dream. AlJazeera headlines declare you the ultimate disruptor.\n", 3);
                CountdownReveal("More money, more problems. They say power corrupts, but hey—at least now you can afford the best lawyers.\n", 3);
                CountdownReveal("You've done it. You've won the Last Dance. The world is yours.\n", 3);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                playerCompany.Money += 10_000_000;
            }
            else
            {
                CountdownReveal("You step into the arena, determined. But Musk's army of accountants and lawyers close in, each wielding tax loopholes like weapons...\n", 3);
                CountdownReveal("You try every trick in the book, from offshore accounts to tax deductions. But it’s no use. Musk’s assets are untouchable.\n", 3);
                CountdownReveal("The economic blow lands. Your stock prices plummet, and suddenly, you’re worth less than a start-up post-IPO.\n", 3);
                CountdownReveal("Brokie. Financially bruised and beaten, you walk away, vowing to rebuild. Maybe next time, you'll hedge your bets.\n", 3);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                MusicStop();
                return;
            }
            MusicStop();
        }
        public static void CompleteChallenge(Company playerCompany)
        {
            playerCompany.AddLegacyPoints(10);
        }

        public static void DisplayStats(Company playerCompany)
        {
            Console.WriteLine($"Legacy Points: {playerCompany.LegacyPoints}");
        }

        public static void HelpMenu()
        {
            Console.Clear();
            Console.WriteLine("===== HELP MENU =====");
            Console.WriteLine("\nWelcome to the MakeYoMani Business Tycoon Game!");
            Console.WriteLine("In this game, your goal is to grow your company, accumulate wealth, and compete against other companies.");

            Console.WriteLine("\n=== Main Actions ===");
            Console.WriteLine("1. Buy Products - Purchase inventory to expand your product line.");
            Console.WriteLine("2. Sell Products - Select products from your inventory to sell for a profit.");
            Console.WriteLine("3. Challenge Companies - Engage in 1v1 business battles with competitors to earn rewards.");
            Console.WriteLine("4. Sabotage - Attempt to undermine competitors, but be prepared to pay if you fail.");
            Console.WriteLine("5. Tax Fraud - A risky move with high rewards and high penalties.");
            Console.WriteLine("6. Last Dance - Face off against the final boss, Elon Musk, for the ultimate victory.");

            Console.WriteLine("\n=== Legacy Points ===");
            Console.WriteLine("Earn Legacy Points by completing challenges and making successful business moves. Accumulate points to unlock the final 'Last Dance' challenge.");

            Console.WriteLine("\n=== Additional Notes ===");
            Console.WriteLine("Press '0' in various actions to return to the main menu without taking an action.");
            Console.WriteLine("Each choice affects your wealth, employee count, and inventory, so choose wisely!\n");
            Console.WriteLine("Press any key to go back to the menu ");
            Console.ReadKey();
        }

        public static void CountdownReveal(string message, int secondsDelay)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(secondsDelay * 20);
            }
            Console.WriteLine();
        }
        //Important to note: MusicPlay and MusicStop methods only work on windows.
        static void MusicPlay()
        {
            if (OperatingSystem.IsWindows())
            {
                SoundPlayer music = new SoundPlayer();
                music.SoundLocation = Path.Combine(Directory.GetCurrentDirectory(), "finalboss.wav");
                music.Play();
            }
        }
        static void MusicStop()
        {
            if (OperatingSystem.IsWindows())
            {
                SoundPlayer music = new SoundPlayer();
                music.SoundLocation = Path.Combine(Directory.GetCurrentDirectory(), "finalboss.wav");
                music.Stop();
            }
        }
    }
}
