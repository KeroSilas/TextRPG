using TextRPG.Model.Abstract;

namespace TextRPG.Model.Enemies;

public class Slime : Character
{
    public Slime(Character player)
    {
        Name = "Slime";
        
        Random rnd = new Random();
        TotalHealth = player.TotalHealth - 20 + rnd.Next(20);
        CurrentHealth = TotalHealth;
        Power = player.Power - 13 + rnd.Next(6);
        Defense = player.Defense - 20 + rnd.Next(7);
    }
}