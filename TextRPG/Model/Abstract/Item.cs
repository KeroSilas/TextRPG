using TextRPG.Model.Enums;

namespace TextRPG.Model.Abstract;

public abstract class Item
{
    public string? Name { get; set; }
    public ItemEffect ItemEffect { get; set; }
    public int Value { get; set; }
}