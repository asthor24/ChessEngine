namespace ChessEngine.ChessBasic {
    public struct Move : IMove
    {
        public ICell From { get; set; }
        public ICell To { get; set; }
    }
}