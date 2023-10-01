using TextRPG.Model.Abstract;
using TextRPG.Model.Enums;

namespace TextRPG.Model.Items;

public class PowerPotion : Item
{
    public PowerPotion()
    {
        Name = "Power Potion";
        ItemEffect = ItemEffect.Power;
        Value = 10;
    }
}