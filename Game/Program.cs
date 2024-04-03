

using Game;

var eventLoop = new EventLoop();
var game = new Game.Game("./map.txt");

game.PrintMap();
eventLoop.LeftHandler += game.OnLeft;
eventLoop.RightHandler += game.OnRight;
eventLoop.UpHandler += game.OnTop;
eventLoop.DownHandler += game.OnDown;
eventLoop.Run();
