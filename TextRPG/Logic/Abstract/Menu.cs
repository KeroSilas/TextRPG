namespace TextRPG.Logic.Abstract;

public abstract class Menu
{
    public abstract void Display();

    public ConsoleKey GetKey()
    {
        return Console.ReadKey().Key;
    }
    
    public string? GetInput()
    {
        return Console.ReadLine();
    }
}