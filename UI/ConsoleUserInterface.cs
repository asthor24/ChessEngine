using ChessEngine.ChessBasic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChessEngine.UI {
    public class ConsoleUserInterface : IUserInterface {
        public void StartTurn() {
            Console.Clear();
        }
        public void OutputPosition(IPosition position, Color rotation) {
            var flip = rotation == Color.Black;
            var grid = GenerateGrid(position, flip);
            var whites = new bool[emptyGridWhite.Count, emptyGridWhite[0].Length];
            var blacks = new bool[emptyGridWhite.Count, emptyGridWhite[0].Length];
            foreach (var piece in position.Pieces) {
                if(piece.Color == Color.White) {
                    whites[GetYGridIndex(piece.Placement.Y, flip), GetXGridIndex(piece.Placement.X, flip)] = true;
                }else {
                    blacks[GetYGridIndex(piece.Placement.Y, flip), GetXGridIndex(piece.Placement.X, flip)] = true;
                }
            }
            for (int i = 0; i < grid.Count; i++) {
                for (int j = 0; j < grid[0].Length; j++) {
                    if(j > 0 && i < grid.Count - 1) { 
                        if((i + j) % 2 == 0) {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                        }else {
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                        }
                    }
                    if(whites[i, j]) {
                        Console.ForegroundColor = ConsoleColor.White; 
                    }
                    if(blacks[i, j]) {
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.Write(grid[i][j]);
                    Console.ResetColor();
                }
                Console.Write('\n');
            }
        }
        public IMove ReadMove() {
            Console.WriteLine("Write the position of the piece you want to move:");
            var from = ReadLine();
            Console.WriteLine("Write the destination of the piece:");
            var to = ReadLine();
            return new Move {
                From = from,
                To = to
            };
        }

        private ICell ReadLine() {
            var line = Console.ReadLine();
            var spl =  line.Split(' ');
            return new Cell {
                X = int.Parse(spl[0]),
                Y = int.Parse(spl[1])
            };
        }

        private List<string> GenerateGrid(IPosition position, bool flip) {
            var grid = (new List<string>(flip ? emptyGridBlack : emptyGridWhite)).Select(s => s.ToCharArray()).ToList();
            foreach (var piece in position.Pieces) {
                grid[GetYGridIndex(piece.Placement.Y, flip)][GetXGridIndex(piece.Placement.X, flip)] = GetPieceCharacter(piece.Type);
            }
            return grid.Select(line => new string(line)).ToList();
        }

        private char GetPieceCharacter(PieceType type) {
            switch(type) {
                case PieceType.King:
                    return 'K';
                case PieceType.Queen:
                    return 'Q';
                case PieceType.Bishop:
                    return 'b';
                case PieceType.Knight:
                    return 'k';
                case PieceType.Rook:
                    return 'r';
                case PieceType.Pawn:
                    return 'p';
                default:
                    throw new ArgumentException("Unknown piece!");
            }
        }

        private int GetXGridIndex(int x, bool flip) {
            if(flip) {
                return emptyGridBlack.Count - x;
            } else {
                return x;
            }
        } 

        private int GetYGridIndex(int y, bool flip) {
            if(flip) {
                return y - 1;
            } else {
                return emptyGridWhite.Count - y - 1;
            }
        }
        private readonly List<string> emptyGridOld = new List<string> { 
            "------------------",
            "8| | | | | | | | |",
            "------------------",
            "7| | | | | | | | |",
            "------------------",
            "6| | | | | | | | |",            
            "------------------",
            "5| | | | | | | | |",
            "------------------",
            "4| | | | | | | | |",
            "------------------",
            "3| | | | | | | | |",
            "------------------",
            "2| | | | | | | | |",
            "------------------",
            "1| | | | | | | | |",
            "------------------",
            " |1|2|3|4|5|6|7|8|",
        };

        private readonly List<string> emptyGridWhite = new List<string> {
            "8        ",
            "7        ",
            "6        ",
            "5        ",
            "4        ",
            "3        ",
            "2        ",
            "1        ",
            " 12345678"
        };

        private readonly List<string> emptyGridBlack = new List<string> {
            "1        ",
            "2        ",
            "3        ",
            "4        ",
            "5        ",
            "6        ",
            "7        ",
            "8        ",
            " 87654321"
        };
    }
}