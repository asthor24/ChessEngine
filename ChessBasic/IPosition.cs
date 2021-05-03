using System.Collections.Generic;

namespace ChessEngine.ChessBasic {
    public interface IPosition {
        public IEnumerable<IPiece> Pieces { get; set; }
    }
}