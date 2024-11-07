using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace warmonsterclass
{
      public class NoursGame
      {
            public string Name { get; set; }
            public int Health { get; set; }
            public int Damage { get; set; }

            public NoursGame(string name, int health, int damage)
            {
                  Name = name;
                  Health = health;
                  Damage = damage;
            }
      }

      public class Enemy
      {
            public string Name { get; set; }
            public int Health { get; set; }
            public int Damage { get; set; }
            public static List<Enemy> Enemies = new List<Enemy>();

            public Enemy(string name, int health, int damage)
            {
                  Name = name;
                  Health = health;
                  Damage = damage;
            }

            static public void DisplayMenu(ref int playerlevel, NoursGame Player, ref bool hasweapon)
            {

                  Console.WriteLine("\n     ❗Choose an option:❗  ");
                  Console.WriteLine("[1] - Fight rats and mini monsters! ⚔️ ");
                  Console.WriteLine("[2] - Fight bigger monsters! ⚔️  ");
                  Console.WriteLine("[3] - View Player Experience ⚔️ ");
                  Console.WriteLine("[4] - Fight The Final Boss! ⚔️  ");
                  Console.WriteLine("[5] - Need help? Get instructions. ❓");
                  Console.WriteLine("[6] - Exit Warmonster... ⛔  ");


                  Console.WriteLine($"\n        📉 {Player.Name} stats: 📈            ");
                  Console.WriteLine($"Health: {Player.Health} ❤️  || Damage: {Player.Damage}  💥");
                  Console.WriteLine($"Experience: {playerlevel} 📊  ||   Weapon: {(hasweapon ? "Yes" : "No")} 🔫❓");
            }

            static public void DisplayTheme(NoursGame Player)
            {

                  Console.WriteLine("┏┓┏┓┏┓╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋┏┓");
                  Console.WriteLine("┃┃┃┃┃┃╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋┏┛┗┓");
                  Console.WriteLine("┃┃┃┃┃┣━━┳━┳┓┏┳━━┳━┓┏━┻┓┏╋━━┳━┓");
                  Console.WriteLine("┃┗┛┗┛┃┏┓┃┏┫┗┛┃┏┓┃┏┓┫━━┫┃┃┃━┫┏┛");
                  Console.WriteLine("┗┓┏┓┏┫┏┓┃┃┃┃┃┃┗┛┃┃┃┣━━┃┗┫┃━┫┃");
                  Console.WriteLine(" ┗┛┗┛┗┛┗┻┛┗┻┻┻━━┻┛┗┻━━┻━┻━━┻┛ ");
                  Console.WriteLine(" ⚔️   Adventure Awaits!  ⚔️ ");
            }

            static public void FightRatsAndMiniMonsters(ref int playerlevel, NoursGame player, ref bool hasweapon)
            {

                  Console.Clear();

                  Enemy MiniMonster = new Enemy("Mini Monster", 50, 10);
                  Enemy Rat = new Enemy("Rat", 30, 5);

                  Enemies.Add(MiniMonster);
                  Enemies.Add(Rat);

                  Enemies.Clear();

                  Console.WriteLine("Which room do you want to enter? 'right' door or 'left' door?🚪");
                  string LeftRightRoom = Console.ReadLine()!;

                  if (LeftRightRoom.ToLower() == "right")
                  {
                        Console.Clear();
                        Console.WriteLine("You have entered a treasure room! 💰");
                        playerlevel += 3;
                        Console.WriteLine($"\nYou found 50 gold coins, and gained {playerlevel} levels! 💰⬆️!");
                        Console.WriteLine($"Current level is: {playerlevel}");
                  }
                  else if (LeftRightRoom.ToLower() == "left")
                  {
                        Console.Clear();

                        Console.WriteLine("You have found a healing potion! 🧪");
                        player.Health += 10;
                        Console.WriteLine($"Your current health is: {player.Health} ⛑️");
                  }
                  else
                  {
                        Console.WriteLine("Wrong input. Choose right or left door!");
                  }
                  Console.WriteLine($"\nA {MiniMonster.Name} approaches with {MiniMonster.Health} HP and {MiniMonster.Damage} damage! 🐀🧟");
                  Console.WriteLine($"A {Rat.Name} approaches with {Rat.Health} HP and {Rat.Damage} Damage 🐀🧟");

                  Console.WriteLine("\nType 'fight' if you want to fight ⚔️, or 'run' 🏃 if you want to run away: ");
                  string FightorRun = Console.ReadLine()!;

                  if (FightorRun.ToLower() == "fight")
                  {
                        Console.Clear();

                        Console.WriteLine($"You have been attacked by a {Rat.Name} 🐀 and a {MiniMonster.Name} 🧟‍♂️");
                        int AttackDamage = MiniMonster.Damage + Rat.Damage;
                        player.Health -= AttackDamage;
                        Console.WriteLine($"\nYour current health is: {player.Health} ⛑️");
                  }
                  else if (FightorRun.ToLower() == "run")
                  {
                        Console.Clear();
                        Console.WriteLine("You attempted to flee!🏃");

                        player.Health -= 5;
                        Console.WriteLine($"You took 5 damage while escaping! Your health is now: {player.Health} 𓀒𓀒");
                        return;
                  }
                  else
                  {
                        Console.WriteLine("Invalid input. choose between fighting or running!");
                  }

                  Console.WriteLine("\nStill want to 'fight' ⚔️ or 'run'?  🏃");
                  string UserInput = Console.ReadLine()!;

                  if (UserInput.ToLower() == "fight")
                  {
                        Console.Clear();
                        Console.WriteLine($"You have defeated the {Rat.Name} and the {MiniMonster.Name} 😵 💀");
                        Console.WriteLine($"\nYour current level is: {playerlevel}");
                        Console.WriteLine($"Your current health is: {player.Health} HP ⛑️");
                  }
                  else if (UserInput.ToLower() == "run")
                  {
                        Console.Clear();
                        Console.WriteLine("You have found a healing potion, while running!🧪");
                        player.Health += 50;
                        Console.WriteLine($"You have gained {player.Health} HP ⛑️");
                        return;
                  }
                  else
                  {
                        Console.WriteLine("Invalid input. choose between fighting or running!");
                  }

                  Console.WriteLine("\nYou have gained 3 levels! ⬆️");
                  playerlevel += 3;
                  Console.WriteLine($"Your current level is: {playerlevel} 📈");
            }

            static public void FightMonster(ref int playerlevel, NoursGame player, ref bool hasweapon)
            {
                  Console.Clear();

                  Console.WriteLine("There are another door 'open' the door 🚪");
                  string UserInput = Console.ReadLine()!;

                  if (UserInput.ToLower() == "open")
                  {
                        Console.Clear();

                        Console.WriteLine("There's a weapon🔫 do you want to 'pick' it up or 'not'? ❌ ");
                        string PickWeapon = Console.ReadLine()!;

                        if (PickWeapon.ToLower() == "pick")
                        {
                              Console.Clear();
                              Console.WriteLine("You have a weapon 🔫");
                              hasweapon = true;
                              player.Damage += 5;

                              Console.WriteLine($"\nYour current damage is: {player.Damage}🔫");
                        }
                        else if (PickWeapon.ToLower() == "not")
                        {
                              Console.Clear();
                              Console.WriteLine($"{player.Name} chose not to pick it up, you have lost damage! ⬇️");
                              player.Damage -= 5;

                              Console.WriteLine($"\n{player.Name}'s current damage is: {player.Damage}⬇️");
                        }
                        else
                        {
                              Console.WriteLine("Wrong input. Do you want a weapon or not? ❗");
                        }
                  }
                  Console.WriteLine("");

                  Enemy Rat = new Enemy("Rat", 50, 5);
                  Enemy Monster = new Enemy("Monster", 100, 10);

                  Enemies.Add(Rat);
                  Enemies.Add(Monster);

                  Console.WriteLine($"\n A {Monster.Name} approaches with {Monster.Health} HP and {Monster.Damage} damage! 🧟");
                  Console.WriteLine($" A {Rat.Name} approaches with {Rat.Health} HP and {Rat.Damage} Damage 🐀");

                  Console.WriteLine("\nDo you want to 'fight' ⚔️ or 'run'? 🏃");
                  string UserFight = Console.ReadLine()!;

                  if (UserFight.ToLower() == "fight")
                  {
                        Console.Clear();
                        Console.WriteLine($"The {Monster.Name} and the {Rat.Name} Attacked you 💥");
                        int TotalDamage = Monster.Damage + Rat.Damage;
                        player.Health -= TotalDamage;
                        Console.WriteLine($"Your current health is: {player.Health} ⛑️");
                        Console.WriteLine("\n Do you want to 'confront'⚔️ the enemies or 'evande'? 🏃");
                        string FightOrRun = Console.ReadLine()!;


                        if (player.Health == 0)
                        {
                              Console.Clear();
                              Console.WriteLine($" You have been defeated.. {player.Name} better luck next time! ⛔");
                              Console.WriteLine("\n⛔❌ GAME OVER ❌⛔");
                              Console.WriteLine("      ▄███████████▄         ");
                              Console.WriteLine("    ▄██▀▀▀▀▀▀▀▀▀▀▀▀██▄      ");
                              Console.WriteLine("  ▄█▀                   ▀█▄  ");
                              Console.WriteLine(" ▀                       ▀   ");
                              Console.WriteLine(" ⛔  Better luck next time! ⛔");
                              return;
                        }
                        else if (FightOrRun.ToLower() == "confront")
                        {
                              Console.Clear();
                              Console.WriteLine($"You have defeated the {Monster.Name} and the {Rat.Name} ☠️ ⚔️");
                              playerlevel += 2;

                              Console.WriteLine($"Your current health is {player.Health} ⛑️");
                        }
                        else if (FightOrRun.ToLower() == "evade")
                        {
                              Console.Clear();
                              Console.WriteLine("You have tripped and lost Your weapon 🔫❌");
                              hasweapon = false;
                              return;
                        }
                        else
                        {
                              Console.WriteLine("Fight or run? Choose. ❗❗");
                        }
                  }
                  else if (UserFight.ToLower() == "run")
                  {
                        Console.Clear();
                        Console.WriteLine("You have tripped𓀒 and lost 10 damage, and 1 level... ⛔ ");
                        player.Health -= 10;
                        playerlevel -= 1;

                        Console.WriteLine($"\n Level is {playerlevel}📈 and {player.Health} HP⛑️ ");
                        return;
                  }
                  else
                  {
                        Console.WriteLine("Fight or run? Choose.❗❗");
                  }

                  Console.WriteLine("\nYou have gained 2 points ⬆️⬆️");
                  playerlevel += 2;
                  Console.WriteLine($"Youre current level is: {playerlevel}");
            }

            static public void UserExperience(ref int playerlevel)
            {

                  Console.WriteLine($"Youre level is: {playerlevel} 📈");
            }

            static public void FightFinalBoss(ref int playerlevel, NoursGame player, ref bool HasWeapon)
            {
                  Console.Clear();

                  Enemy FinalBoss = new Enemy("Final boss", 150, 30);
                  Enemies.Add(FinalBoss);

                  if (!HasWeapon)
                  {
                        Console.WriteLine($"You can't fight {FinalBoss.Name} because you have lost Your weapon");
                  }

                  while (player.Health > 0 && FinalBoss.Health > 0)
                  {

                        Console.WriteLine($"The {FinalBoss.Name} is attacking you with {FinalBoss.Damage} Damage ☢️💥");
                        player.Health -= FinalBoss.Damage;
                        Console.WriteLine($"Your current health: {player.Health} ⛑️");

                        if (player.Health < 0)
                        {
                              Console.Clear();
                              Console.WriteLine($"You have been defeated by the {FinalBoss.Name}. Game over. ❌");
                              Console.WriteLine("\n⛔❌ GAME OVER ❌⛔");
                              Console.WriteLine("       ▀         ▀  ");
                              Console.WriteLine("                             ");
                              Console.WriteLine("      ▄███████████▄          ");
                              Console.WriteLine("    ▄██▀▀▀▀▀▀▀▀▀▀▀▀██▄▄      ");
                              Console.WriteLine("  ▄█▀                  ▀█▄   ");
                              Console.WriteLine(" ▀                       ▀   ");
                              Console.WriteLine(" ⛔  Better luck next time! ⛔");
                              return;
                        }

                        Console.WriteLine("\nYour turn do you want to 'attack' or 'heal'?⛑️🔫");
                        string AttackorHeal = Console.ReadLine()!;

                        if (AttackorHeal.ToLower() == "attack")
                        {
                              Console.Clear();
                              FinalBoss.Health -= player.Damage;
                              Console.WriteLine($"You have attacked the {FinalBoss.Name}, dealing {player.Damage} damage to the boss!💥🔫");
                        }
                        else if (AttackorHeal.ToLower() == "heal")
                        {
                              Console.Clear();
                              player.Health += 20;
                              Console.WriteLine("You have gained 20 health! ⛑️");
                              Console.WriteLine($" Your current health is: {player.Health} ⛑️");
                        }
                        else
                        {
                              Console.WriteLine("Invalid action. You have missed your turn ❌❌ ");
                        }

                        if (FinalBoss.Health <= 0)
                        {
                              Console.Clear();
                              Console.WriteLine($"You have defeated the {FinalBoss.Name}. Victory is yours 🏆");
                              playerlevel += 20;
                              Console.WriteLine($"\n 📈⬆️ You have gained {playerlevel} levels! ⬆️📈");
                              Console.WriteLine("\n  _    _ _    _                   ");
                              Console.WriteLine(" | |  | (_)    | |                    ");
                              Console.WriteLine(" | |  | |_  ___| |_ ___  _ __ _   _   ");
                              Console.WriteLine(" | |/\\| | |/ __| __/ _ \\| '__| | |  ");
                              Console.WriteLine(" \\  /\\  / | (__| || (_) | |  | |_|  ");
                              Console.WriteLine("  \\/  \\/|_|\\___|\\__\\___/|_| | |  ");
                              Console.WriteLine("                               __/ |  ");
                              Console.WriteLine("                              |___/   ");
                              return;
                        }

                        Console.WriteLine($"The {FinalBoss.Name} attacks you for {FinalBoss.Damage} damage!💥");
                        player.Health -= FinalBoss.Damage;

                        Console.WriteLine($"\nYour current health is: {player.Health} ⛑️⛑️ ");

                        if (player.Health <= 0)
                        {
                              Console.Clear();
                              Console.WriteLine($"You have been defeated by the {FinalBoss.Name}. Game over. ⛔❌");
                              Console.WriteLine("\n⛔❌ GAME OVER ❌⛔");
                              Console.WriteLine("       ▀         ▀  ");
                              Console.WriteLine("                             ");
                              Console.WriteLine("      ▄███████████▄          ");
                              Console.WriteLine("    ▄██▀▀▀▀▀▀▀▀▀▀▀▀██▄▄      ");
                              Console.WriteLine("  ▄█▀                  ▀█▄   ");
                              Console.WriteLine(" ▀                       ▀   ");
                              Console.WriteLine(" ⛔  Better luck next time! ⛔");
                        }
                  }
            }

            static public void UserNeedHelp(NoursGame Player)
            {

                  Console.WriteLine("#          📝 Instructions: How to Play 📝         ");
                  Console.WriteLine("----------------------------------------------------");
                  Console.WriteLine("[1] Fight rats and mini monsters to gain levels.");
                  Console.WriteLine("[2] Reach level 3 to fight bigger monsters.");
                  Console.WriteLine("[3] At level 5, you can challenge the Final Boss!");
                  Console.WriteLine("[4] - If you lose Your weapon you can't fight the finalboss!");
                  Console.WriteLine("[5] View experience points to track progress.");

                  Console.WriteLine($"\n      Good luck, {Player.Name}! 🏆  ");
            }
      }
}
