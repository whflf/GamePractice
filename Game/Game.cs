
namespace Game;

public class Game(string mapFile)
{
    public string MapFile { private get; set; } = mapFile;
    private static string[] mapComponents;

    public void PrintMap()
    {
        var map = File.ReadAllText(this.MapFile);
        mapComponents = map.Split('\n');

        Console.Clear();
        Console.Write(map);
        Console.SetCursorPosition(1, 1);
        Console.Write('@');
    }

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
        var newColumn = Console.CursorTop + deltaTop;
        var newRow = Console.CursorLeft + deltaLeft - 1;

        if (mapComponents[newColumn][newRow] != ' ')
        {
            return;
        }

        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        Console.Write(' ');

        Console.SetCursorPosition(newRow, newColumn);
        Console.Write('@');
    }
}