
namespace GameUI;

public static class Map
{
    public static string[] MapComponents { get; private set; }

    public static Point characterCoordinates = new Point (1,1);

    public static void GenerateMap(string mapFile)
    {
        MapComponents = File.ReadAllLines(mapFile);
    }
    
    public static bool TryMove(int deltaLeft, int deltaTop)
    {
        var newY = characterCoordinates.Y + deltaTop;
        var newX = characterCoordinates.X + deltaLeft ;

        if (MapComponents[newY][newX] == ' ')
        {
            characterCoordinates.X = newX;
            characterCoordinates.Y = newY;
            return true;
        }
        return false;
       
    }
}