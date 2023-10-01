using System.Drawing;
using Pastel;
using TextRPG.Model.Abstract;
using TextRPG.Logic.Abstract;

namespace TextRPG.Logic.Menus;

public class BattleMenu : Menu
{
    private PlayableCharacter player;
    private Character enemy;
    public override void Display()
    {
        Console.Clear();
        Console.WriteLine($"{"YOU".Pastel(Color.FromArgb(94, 188, 255))}: {player.CurrentHealth} / {player.TotalHealth}");
        Console.WriteLine($"{enemy.Name.Pastel(Color.FromArgb(255, 94, 94))}: {enemy.CurrentHealth} / {enemy.TotalHealth}");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("| 1. Attack                             |");
        Console.WriteLine("| 2. Inventory                          |");
        Console.WriteLine("| 3. Details                            |");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"{"Press the corresponding key to choose..".Pastel(Color.FromArgb(165, 229, 250))}");
        switch (GetKey())
        {
            case ConsoleKey.D1:
                Console.Clear();
                enemy.CurrentHealth -= player.Attack(enemy);
                player.CurrentHealth -= enemy.Attack(player);
                Console.WriteLine($"You attack {enemy.Name} for {player.Attack(enemy).ToString().Pastel(Color.FromArgb(255, 94, 94))} damage!");
                Thread.Sleep(1000);
                Console.WriteLine($"{enemy.Name} hits you back for {enemy.Attack(player).ToString().Pastel(Color.FromArgb(255, 94, 94))} damage!");
                Thread.Sleep(2000);
                if (!player.IsAlive())
                {
                    Console.Clear();
                    Console.WriteLine("You've died!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("Game Over!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }

                if (!enemy.IsAlive())
                {
                    Console.Clear();
                    Console.WriteLine($"You've defeated the {enemy.Name}!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
                UpdateStatus(ref player, ref enemy);
                Display();
                break;
            case ConsoleKey.D2:
                Console.Clear();
                Console.WriteLine("-----------------------------------------");
                for(int i = 0; i < player.Inventory.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {player.Inventory.ElementAt(i).Name}");
                }
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"{"Press the corresponding key to use item..".Pastel(Color.FromArgb(165, 229, 250))}");
                Console.WriteLine($"{"Press ENTER if you wish to cancel..".Pastel(Color.FromArgb(165, 229, 250))}");
                switch (GetKey())
                {
                    case ConsoleKey.D1: 
                        Console.Clear();
                        Console.WriteLine($"You've used a {player.Inventory.ElementAt(0).Name}");
                        player.UseItem(0);
                        Thread.Sleep(2000);
                        break;
                    case ConsoleKey.D2: 
                        Console.Clear();
                        Console.WriteLine($"You've used a {player.Inventory.ElementAt(1).Name}");
                        player.UseItem(1);
                        Thread.Sleep(2000);
                        break;
                    case ConsoleKey.D3: 
                        Console.Clear();
                        Console.WriteLine($"You've used a {player.Inventory.ElementAt(2).Name}");
                        player.UseItem(2);
                        Thread.Sleep(2000);
                        break;
                    case ConsoleKey.D4: 
                        Console.Clear();
                        Console.WriteLine($"You've used a {player.Inventory.ElementAt(3).Name}");
                        player.UseItem(3);
                        Thread.Sleep(2000);
                        break;
                    case ConsoleKey.D5: 
                        Console.Clear();
                        Console.WriteLine($"You've used a {player.Inventory.ElementAt(4).Name}");
                        player.UseItem(4);
                        Thread.Sleep(2000);
                        break;
                    case ConsoleKey.D6: 
                        Console.Clear();
                        Console.WriteLine($"You've used a {player.Inventory.ElementAt(5).Name}");
                        player.UseItem(5);
                        Thread.Sleep(2000);
                        break;
                    case ConsoleKey.D7: 
                        Console.Clear();
                        Console.WriteLine($"You've used a {player.Inventory.ElementAt(6).Name}");
                        player.UseItem(6);
                        Thread.Sleep(2000);
                        break;
                    case ConsoleKey.D8: 
                        Console.Clear();
                        Console.WriteLine($"You've used a {player.Inventory.ElementAt(7).Name}");
                        player.UseItem(7);
                        Thread.Sleep(2000);
                        break;
                    case ConsoleKey.D9: 
                        Console.Clear();
                        Console.WriteLine($"You've used a {player.Inventory.ElementAt(8).Name}");
                        player.UseItem(8);
                        Thread.Sleep(2000);
                        break;
                    case ConsoleKey.Enter:
                        break;
                }
                Display();
                break;
            case ConsoleKey.D3:
                Console.Clear();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"{"YOU".Pastel(Color.FromArgb(94, 188, 255))} (Level {player.CurrentLevel})");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Health: {player.CurrentHealth} / {player.TotalHealth}");
                Console.WriteLine($"Power: {player.Power}");
                Console.WriteLine($"Defense: {player.Defense}");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"{enemy.Name.Pastel(Color.FromArgb(255, 94, 94))}");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Health: {enemy.CurrentHealth} / {enemy.TotalHealth}");
                Console.WriteLine($"Power: {enemy.Power}");
                Console.WriteLine($"Defense: {enemy.Defense}");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"{"Press ENTER to resume..".Pastel(Color.FromArgb(165, 229, 250))}");
                while (GetKey() != ConsoleKey.Enter)
                {
                }
                Console.Clear();
                Display();
                break;
        }
    }

    public void UpdateStatus(ref PlayableCharacter player, ref Character enemy)
    {
        this.player = player;
        this.enemy = enemy;
    }
}