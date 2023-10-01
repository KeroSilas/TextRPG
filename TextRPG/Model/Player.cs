using TextRPG.Model.Enums;
using TextRPG.Model.Abstract;
using TextRPG.Model.Items;

namespace TextRPG.Model;

public class Player : PlayableCharacter
{
    private int[] ExpArray
    {
        get { return new[] { 1000, 3000, 6000, 10000, 15000, 21000, 28000, 36000, 45000, 55000, 66000, 78000 }; }
    }
    public Player(string name)
    {
        Name = name;
        TotalHealth = 100;
        CurrentHealth = 100;
        Power = 35;
        Defense = 35;
        CurrentLevel = 1;
        TotalExp = 0;
        Inventory = new List<Item>();
        Inventory.Add(new HealthPotion());
        Inventory.Add(new HealthPotion());
        Inventory.Add(new HealthPotion());
        Inventory.Add(new PowerPotion());
        Inventory.Add(new PowerPotion());
        Inventory.Add(new PowerPotion());
        Inventory.Add(new DefensePotion());
        Inventory.Add(new DefensePotion());
        Inventory.Add(new DefensePotion());
    }

    public override void UseItem(int index)
    {
        Item item = Inventory.ElementAt(index);
        switch (item.ItemEffect)
        {
            case ItemEffect.Heal:
                if (CurrentHealth + item.Value > TotalHealth)
                {
                    CurrentHealth = TotalHealth;
                }
                else
                {
                    CurrentHealth += item.Value;
                }
                break;
            
            case ItemEffect.Power:
                Power += item.Value;
                break;
            
            case ItemEffect.Defense:
                Defense += item.Value;
                break;
        }
        Inventory.RemoveAt(index);
    }
    
    public override bool LevelUp(int exp)
    {
        int oldLevel = CurrentLevel;

        TotalExp += exp;
        while (CurrentLevel - 1 < ExpArray.Length && TotalExp > ExpArray[CurrentLevel - 1])
        {
            ++CurrentLevel;
            TotalHealth += 20;
            Power += 7;
            Defense += 7;

            CurrentHealth = TotalHealth; // Reset health on level up
        }
        int newLevel = CurrentLevel;

        return newLevel > oldLevel;
    }
}