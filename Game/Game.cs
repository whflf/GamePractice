
namespace Game;

public class Game
{
    public void OnLeft(object sender, EventArgs args)
        => Game.WriteAt(-1, 0);

    public void OnRight(object sender, EventArgs args)
        => Game.WriteAt(1, 0);
    
    public void OnTop(object sender, EventArgs args)
        => Game.WriteAt(0, -1);
    public void OnDown(object sender, EventArgs args)
        => Game.WriteAt(0, 1);
    
    private static void WriteAt(int deltaLeft, int deltaTop)
    {
        var originalColumn = Console.CursorTop;
        var originalRow = Console.CursorLeft;

        Console.Write(' ');
        
        Console.SetCursorPosition(originalRow + deltaLeft, originalColumn + deltaTop); 
        Console.Write('@');
    }
}