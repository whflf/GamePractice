using System.Diagnostics;
using Game;
static void Main(string[] args)
{
    var eventLoop = new EventLoop();
    var game = new Game.Game("klfdf");
    eventLoop.LeftHandler += game.OnLeft;
    eventLoop.RightHandler += game.OnRight;
    eventLoop.UpHandler += game.OnTop;
    eventLoop.DownHandler += game.OnDown;
    eventLoop.Run();
}

var eventLoop = new EventLoop();
var game = new Game.Game("./map.txt");

game.PrintMap();
eventLoop.LeftHandler += game.OnLeft;
eventLoop.RightHandler += game.OnRight;
eventLoop.Run();
