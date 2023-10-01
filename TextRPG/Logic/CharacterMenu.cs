using System.Drawing;
using Pastel;

namespace TextRPG.Logic;

public class CharacterMenu : Menu
{
    public override void Display()
    {
        Console.WriteLine("| 6. Inventory                          |");
        Console.WriteLine("| 7. Save Game                          |");
        Console.WriteLine("| 8. Exit to Main Menu                  |");
        Console.WriteLine("| 9. Exit Game                          |");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"{"Press the corresponding key to choose".Pastel(Color.FromArgb(165, 229, 250))}");
        switch (GetKey())
        {
            case ConsoleKey.D6:
                break;
            case ConsoleKey.D7:
                break;
            case ConsoleKey.D8:
                break;
            case ConsoleKey.D9:
                break;
        }
    }
}