using ChessEngine.Player;

namespace ChessEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(
                new Human(),
                new Human()
            );
            game.Run();
        }
    }
}
