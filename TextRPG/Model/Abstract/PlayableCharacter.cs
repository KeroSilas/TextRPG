namespace TextRPG.Model.Abstract;

public abstract class PlayableCharacter : Character
{
    public int CurrentLevel { get; set; }
    public int TotalExp { get; set; }
    public List<Item> Inventory { get; set; }
    public abstract void UseItem(int index);
    public abstract bool LevelUp(int exp);
}