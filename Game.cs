using ChessEngine.Player;
using ChessEngine.ChessBasic;

namespace ChessEngine {
    public class Game {
        public Game(IPlayer white, IPlayer black) {
            this.white = white;
            this.black = black;
        }

        public void Run() {
            while(true) {
                white.GetMove(
                    Constants.StartingPosition,
                    Constants.StartingPosition,
                    Color.White
                );
                black.GetMove(
                    Constants.StartingPosition,
                    Constants.StartingPosition,
                    Color.Black
                );
            }
        }

        private IPlayer white;
        private IPlayer black;
    }
}