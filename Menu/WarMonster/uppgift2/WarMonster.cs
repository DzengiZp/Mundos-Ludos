using System;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Net.Quic;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using warmonsterclass;

namespace warmonsterclass
{
      public class WarMonster
      {
            static public List<Enemy> Enemies = new List<Enemy>();
            public static void PlayWarMonster()
            {

                  int playerlevel = 0;
                  int menuchoice;
                  bool userisplaying = true;
                  bool hasweapon = false;
                  bool firstTimeTheme = true;

                  Console.Write("Please enter your name: ");
                  string UserName = Console.ReadLine()!;

                  NoursGame Player = new NoursGame(UserName, 200, 100);

                  while (userisplaying)
                  {
                        Console.Clear();

                        if (firstTimeTheme)
                        {
                              Console.WriteLine($"Welcome to the WarMonster!!, {Player.Name} hopefully you'll have fun!");

                              Enemy.DisplayTheme(Player);

                              firstTimeTheme = false;
                        }

                        Enemy.DisplayMenu(ref playerlevel, Player, ref hasweapon);

                        string PlayerChoice = Console.ReadLine()!;

                        if (int.TryParse(PlayerChoice, out menuchoice))
                        {
                              switch (menuchoice)
                              {
                                    case 1:
                                          Console.Clear();
                                          if (playerlevel <= 3)
                                          {
                                                Enemy.FightRatsAndMiniMonsters(ref playerlevel, Player, ref hasweapon);
                                          }
                                          else
                                          {
                                                Console.WriteLine($"{Player.Name} are too strong to fight rats and mini monsters! 💪");
                                          }
                                          break;

                                    case 2:
                                          Console.Clear();
                                          if (playerlevel >= 3)
                                          {
                                                Enemy.FightMonster(ref playerlevel, Player, ref hasweapon);
                                          }
                                          else
                                          {
                                                Console.WriteLine($"{Player.Name} need to be level 3 to fight Monsters! ⚠️");
                                          }
                                          break;

                                    case 3:
                                          Console.Clear();
                                          Enemy.UserExperience(ref playerlevel);
                                          break;

                                    case 4:
                                          Console.Clear();
                                          if (playerlevel >= 5)
                                          {
                                                Console.WriteLine($"{Player.Name} can now fight the final boss!🤼");
                                                Enemy.FightFinalBoss(ref playerlevel, Player, ref hasweapon);
                                          }
                                          else if (playerlevel <= 5)
                                          {
                                                Console.WriteLine($"{Player.Name} need to be level 5 to fight the final boss!🛠️");
                                          }
                                          else
                                          {
                                                Console.WriteLine("Choose in the menu 1-6!");
                                          }
                                          break;

                                    case 5:
                                          Console.Clear();
                                          Console.WriteLine("Here are the instructions:❗❓");
                                          Enemy.UserNeedHelp(Player);
                                          break;

                                    case 6:
                                          userisplaying = false;
                                          Console.Clear();

                                          Console.WriteLine("Exiting Warmonster...  ☹");
                                          break;

                                    default:
                                          Console.WriteLine("Start by choosing number 1 ❗❗");
                                          break;
                              }
                        }
                        else
                        {
                              Console.WriteLine("Start by choosing numer 1! ❗❗");
                        }
                        Console.WriteLine($"\nPress any key to get to the menu {Player.Name}....");
                        Console.ReadKey();
                  }
            }
      }
}