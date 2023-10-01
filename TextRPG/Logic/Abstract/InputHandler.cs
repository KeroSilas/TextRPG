namespace TextRPG.Logic.Abstract;

public abstract class InputHandler
{
    public ConsoleKey GetKey()
    {
        return Console.ReadKey().Key;
    }
    
    public string? GetInput()
    {
        return Console.ReadLine();
    }
}