using TextRPG.Model.Abstract;

namespace TextRPG.Model.Enemies;

public class KingSlime : Character
{
    public KingSlime(Character player)
    {
        Name = "King Slime";
        
        Random rnd = new Random();
        TotalHealth = player.TotalHealth - 20 + rnd.Next(40);
        CurrentHealth = TotalHealth;
        Power = player.Power - 13 + rnd.Next(6);
        Defense = player.Defense - 10 + rnd.Next(20);
    }
}