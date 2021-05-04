using System.Collections.Generic;
using ChessEngine.ChessBasic;

namespace ChessEngine {
    public static class Constants {
        public const int MIN_X_POSITION = 1;
        public const int MAX_X_POSITION = 8;
        public const int MIN_Y_POSITION = 1;
        public const int MAX_Y_POSITION = 8;

        public static readonly IPosition StartingPosition = new Position {
            Pieces = new List<IPiece> {
                new Piece {
                    Color = Color.White,
                    Type = PieceType.King,
                    Placement = new Cell {
                        X = 1,
                        Y = 1
                    }
                },
                new Piece {
                    Color = Color.White,
                    Type = PieceType.Queen,
                    Placement = new Cell {
                        X = 2,
                        Y = 1
                    }
                },
                new Piece {
                    Color = Color.Black,
                    Type = PieceType.King,
                    Placement = new Cell {
                        X = 8,
                        Y = 8
                    }
                },
                new Piece {
                    Color = Color.Black,
                    Type = PieceType.Queen,
                    Placement = new Cell {
                        X = 7,
                        Y = 8
                    }
                }
            }
        };
    }
}