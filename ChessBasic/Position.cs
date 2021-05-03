using System.Collections.Generic;

namespace ChessEngine.ChessBasic {
    public class Position : IPosition {
        public IEnumerable<IPiece> Pieces { get; set; }
    }
}