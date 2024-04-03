
namespace Game;

public class Game(string mapFile)
{
    public string MapFile { private get; set; } = mapFile;

    public void PrintMap()
    {
        var map = File.ReadAllText(this.MapFile);

        Console.Clear();
        Console.Write(map);
        Console.SetCursorPosition(1, 1);
        Console.Write('@');
    }

    public void OnLeft(object sender, EventArgs args)
        => Console.WriteLine("Going left");

    public void OnRight(object sender, EventArgs args)
        => Console.WriteLine("Going right");

    protected static void WriteAt(string s, int x, int y)
    {
        var origCol = Console.CursorTop;
        var origRow = Console.CursorLeft;

        try
        {
            Console.SetCursorPosition(origCol+x, origRow+y);
            Console.Write(s);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
        }
    }
}