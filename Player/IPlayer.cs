using ChessEngine.ChessBasic;

namespace ChessEngine.Player {
    public interface IPlayer {
        public IMove GetMove(IPosition current, IPosition previous, Color whoseTurn);
    }
}