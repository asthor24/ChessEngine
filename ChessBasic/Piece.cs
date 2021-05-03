namespace ChessEngine.ChessBasic {
    public class Piece : IPiece {
        public PieceType Type { get; set; }
        public Color Color { get; set; }
        public ICell Placement { get; set; }
    }
}