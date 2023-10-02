using System.Drawing;
using Pastel;
using TextRPG.Logic.Menus;
using TextRPG.Model.Abstract;

namespace TextRPG.Logic.Abstract;

public abstract class Level : InputHandler
{
    private BattleMenu bm;
    public abstract void Start(ref PlayableCharacter player);

    public void InitiateBattle(ref PlayableCharacter player, ref Character enemy)
    {
        Console.Clear();
        Console.WriteLine($"You have encountered a {enemy.Name}!");
        Thread.Sleep(2500);
        bm = new BattleMenu(ref player, ref enemy);
        bm.Display();
        if(player.IsAlive())
            CheckLevelUp(ref player, ref enemy);
        else
            Environment.Exit(0);
    }

    private void CheckLevelUp(ref PlayableCharacter player, ref Character enemy)
    {
        int expGain = (enemy.Power + enemy.Defense) * 50;
        Console.WriteLine($"Killing {enemy.Name} has earned you {expGain} experience!");
        Thread.Sleep(2000);
        if (player.LevelUp(expGain))
        {
            Console.Clear();
            Console.WriteLine($"You've leveled up! Your level is now {player.CurrentLevel.ToString().Pastel(Color.FromArgb(148, 255, 94))}");
            Thread.Sleep(1000);
            Console.WriteLine("Health, Power and Defense has increased!");
            Thread.Sleep(2500);
            Console.Clear();
        }
    }
}