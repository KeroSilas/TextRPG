using TextRPG.Model.Abstract;

namespace TextRPG.Model.Enemies;

public class Goblin : Character
{
    public Goblin(Character player)
    {
        Name = "Goblin";
        
        Random rnd = new Random();
        TotalHealth = player.TotalHealth - 10 + rnd.Next(20);
        CurrentHealth = TotalHealth;
        Power = player.Power - 10 + rnd.Next(10);
        Defense = player.Defense - 10 + rnd.Next(5);
    }
}