using TextRPG.Model.Abstract;

namespace TextRPG.Model.Enemies;

public class ElderDragon : Character
{
    public ElderDragon(Character player)
    {
        Name = "Elder Dragon";
        
        Random rnd = new Random();
        TotalHealth = player.TotalHealth + rnd.Next(60);
        CurrentHealth = TotalHealth;
        Power = player.Power - 5 + rnd.Next(40);
        Defense = player.Defense - 5 + rnd.Next(40);
    }
}