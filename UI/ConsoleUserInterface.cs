using ChessEngine.ChessBasic;
using System;

namespace ChessEngine.UI {
    public class ConsoleUserInterface : IUserInterface {
        public void StartTurn() {
            Console.Clear();
        }
        public void OutputPosition(IPosition position, Color rotation) {
            Console.WriteLine("meep moop outputting position");
        }
        public IMove ReadMove() {
            throw new NotImplementedException();
        }
    }
}