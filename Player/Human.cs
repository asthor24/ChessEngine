using ChessEngine.ChessBasic;
using ChessEngine.UI;

namespace ChessEngine.Player {
    public class Human : IPlayer {
        public IMove GetMove(IPosition current, IPosition previous, Color whoseTurn) {
            ui.OutputPosition(current, whoseTurn);
            return new Move {
                From = new Cell {
                    X = 1,
                    Y = 2
                },
                To = new Cell {
                    X = 1,
                    Y = 3 
                }
            };
        }

        private IUserInterface ui = new ConsoleUserInterface();
    }
}