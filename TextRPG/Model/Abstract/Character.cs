namespace TextRPG.Model.Abstract;

public abstract class Character
{
    public string? Name { get; set; }
    public int TotalHealth { get; set; }
    public int CurrentHealth { get; set; }
    public int Power { get; set; }
    public int Defense { get; set; }

    public int Attack(Character target)
    {
        Random rnd = new Random();
        return Power * Power / target.Defense;
    }

    public bool IsAlive()
    {
        return CurrentHealth > 0;
    }
}