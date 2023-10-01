using TextRPG.Model.Abstract;
using TextRPG.Model.Enums;

namespace TextRPG.Model.Items;

public class HealthPotion : Item
{
    public HealthPotion()
    {
        Name = "Health Potion";
        ItemEffect = ItemEffect.Heal;
        Value = 100;
    }
}