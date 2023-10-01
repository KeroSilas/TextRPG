using TextRPG.Model.Abstract;

namespace TextRPG.Model.Enemies;

public class Dragon : Character
{
    public Dragon(Character player)
    {
        Name = "Dragon";
        
        Random rnd = new Random();
        TotalHealth = player.TotalHealth - 10 + rnd.Next(30);
        CurrentHealth = TotalHealth;
        Power = player.Power - 5 + rnd.Next(25);
        Defense = player.Defense - 10 + rnd.Next(25);
    }
}