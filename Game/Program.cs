using Game;

static void Main(string[] args)
{
    var eventLoop = new EventLoop();
    var game = new Game.Game();
    eventLoop.LeftHandler += game.OnLeft;
    eventLoop.RightHandler += game.OnRight;
    eventLoop.UpHandler += game.OnTop;
    eventLoop.DownHandler += game.OnDown;
    eventLoop.Run();
}