using TextRPG.Model.Abstract;
using TextRPG.Model.Enums;

namespace TextRPG.Model.Items;

public class DefensePotion : Item
{
    public DefensePotion()
    {
        Name = "Defense Potion";
        ItemEffect = ItemEffect.Defense;
        Value = 10;
    }
}