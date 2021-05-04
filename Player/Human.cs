using ChessEngine.ChessBasic;
using ChessEngine.UI;

namespace ChessEngine.Player {
    public class Human : IPlayer {
        public IMove GetMove(IPosition current, IPosition previous, Color whoseTurn) {
            ui.StartTurn();
            ui.OutputPosition(current, whoseTurn);
            return ui.ReadMove();
        }

        private IUserInterface ui = new ConsoleUserInterface();
    }
}