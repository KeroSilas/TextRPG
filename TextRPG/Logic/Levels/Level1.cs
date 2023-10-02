using System.Drawing;
using Pastel;
using TextRPG.Logic.Abstract;
using TextRPG.Model.Abstract;
using TextRPG.Model.Enemies;

namespace TextRPG.Logic.Levels;

public class Level1 : Level
{
    public override void Start(ref PlayableCharacter player)
    {
        Console.WriteLine($"You're stranded in the middle of a forest, with no visible end in sight.");
        Thread.Sleep(3000);
        Console.WriteLine($"You wander around for a bit, until you stumble over something wet by your feet..");
        Console.WriteLine($"{"Press ENTER to continue..".Pastel(Color.FromArgb(165, 229, 250))}");
        while (GetKey() != ConsoleKey.Enter)
        {
        }
        Character enemy = new Slime(player);
        InitiateBattle(ref player, ref enemy);
        
        Console.WriteLine($"After defeating the {enemy.Name}, you decide to use its gel to craft a torch.");
        Console.WriteLine($"You use this torch to hopefully get someones attention that can help you out of this forest.");
        Thread.Sleep(3000);
        Console.WriteLine($"However as a consequence, the smoke from the torch has lured in an unexpected foe who is thirsty for blood..");
        Console.WriteLine($"{"Press ENTER to continue..".Pastel(Color.FromArgb(165, 229, 250))}");
        while (GetKey() != ConsoleKey.Enter)
        {
        }
        enemy = new Goblin(player);
        InitiateBattle(ref player, ref enemy);
        
        Console.WriteLine($"You loot the {enemy.Name}'s body for any useful items and you chance to find a magic trinket that allows for flight.");
        Console.WriteLine($"You think to yourself for a bit, and come to the conclusion that you need a little boost to get off the ground first.");
        Thread.Sleep(3000);
        Console.WriteLine($"After wandering around in search for anything that could help you get off the ground a little, you run into a huge Slime..");
        Console.WriteLine($"{"Press ENTER to continue..".Pastel(Color.FromArgb(165, 229, 250))}");
        while (GetKey() != ConsoleKey.Enter)
        {
        }
        enemy = new KingSlime(player);
        InitiateBattle(ref player, ref enemy);
        
        
        Console.WriteLine($"You use the {enemy.Name}'s massive gelatinous body to bounce yourself up high into the air, allowing for the trinket to finally take effect.");
        Console.WriteLine($"After finally getting through the thick groove of tree leaves high up in the air, you spot a creature in the distance.");
        Thread.Sleep(3000);
        Console.WriteLine($"This creature seems to have noticed you as well, and is now flying straight towards you..");
        Console.WriteLine($"{"Press ENTER to continue..".Pastel(Color.FromArgb(165, 229, 250))}");
        while (GetKey() != ConsoleKey.Enter)
        {
        }
        enemy = new Dragon(player);
        InitiateBattle(ref player, ref enemy);
        
        Console.WriteLine($"Upon killing the {enemy.Name}, it lets out a final screech, echoing through the entire land.");
        Thread.Sleep(3000);
        Console.WriteLine($"You decide to fly away as fast as you can, but as soon as you spot an end to the forest in the distance, you notice that you're being chased by yet another dragon..");
        Console.WriteLine($"{"Press ENTER to continue..".Pastel(Color.FromArgb(165, 229, 250))}");
        while (GetKey() != ConsoleKey.Enter)
        {
        }
        enemy = new ElderDragon(player);
        InitiateBattle(ref player, ref enemy);
        
        Console.WriteLine($"You breathe a sigh of relief after having defeated the {enemy.Name}.");
        Thread.Sleep(3000);
        Console.WriteLine($"You fly closer to the ground, preparing for a landing..");
        Console.WriteLine($"{"Press ENTER to continue..".Pastel(Color.FromArgb(165, 229, 250))}");
        while (GetKey() != ConsoleKey.Enter)
        {
        }
        // new Level2().Start(ref player);
    }
}