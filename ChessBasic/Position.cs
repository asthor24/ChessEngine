using System.Collections.Generic;

namespace ChessEngine.ChessBasic {
    public struct Position : IPosition {
        public IEnumerable<IPiece> Pieces { get; set; }
    }
}