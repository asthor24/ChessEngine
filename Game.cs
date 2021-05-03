using ChessEngine.Player;
using ChessEngine.ChessBasic;

namespace ChessEngine {
    public class Game {
        public Game(IPlayer white, IPlayer black) {
            this.white = white;
            this.black = black;
        }

        public void Run() {
            white.GetMove(
                Constants.StartingPosition,
                Constants.StartingPosition,
                Color.White
            );
        }

        private IPlayer white;
        private IPlayer black;
    }
}