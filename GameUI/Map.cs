
namespace GameUI;

public class Map(string mapFile)
{
    public string MapFile { private get; set; } = mapFile;
    public string[] MapComponents { get; private set; } = File.ReadAllLines(mapFile);
    
    /*private static void WriteAt(int deltaLeft, int deltaTop)
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
    }*/
}