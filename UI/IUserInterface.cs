using ChessEngine.ChessBasic;

namespace ChessEngine.UI {
    public interface IUserInterface {
        public void StartTurn();
        public void OutputPosition(IPosition position, Color rotation);
        public IMove ReadMove();
    }
}