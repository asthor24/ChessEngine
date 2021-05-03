namespace ChessEngine.ChessBasic {
    public interface IMove {
        public ICell From { get; set; }
        public ICell To { get; set; }
    }
}