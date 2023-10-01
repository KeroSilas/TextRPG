using System.Drawing;
using Pastel;
using TextRPG.Logic.Levels;
using TextRPG.Model;
using TextRPG.Model.Abstract;

namespace TextRPG.Logic;

public class MainMenu : Menu
{
    public override void Display()
    {
        Console.WriteLine($"Welcome to {"Twisted Lands".Pastel(Color.FromArgb(201, 94, 255))}");
        Console.WriteLine("Press ENTER to continue..");
        while (GetKey() != ConsoleKey.Enter)
        {
        }
        Console.Clear();
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("| 1. New Game                           |");
        Console.WriteLine("| 2. Exit Game                          |");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"{"Press the corresponding key to choose..".Pastel(Color.FromArgb(165, 229, 250))}");
        switch (GetKey())
        {
            case ConsoleKey.D1:
                NewGame();
                break;
            case ConsoleKey.D2:
                break;
        }
    }

    public void NewGame()
    {
        Console.Clear();
        Console.WriteLine("Welcome, traveler! Now what is your name?");
        PlayableCharacter player = new Player(GetInput());
        new Level1().Start(ref player);
    }
}