using System;
using ChessEngine;
namespace ChessEngine.ChessBasic {
    public struct Cell : ICell
    {
        public int X { 
            get => x; 
            set {
                if(Constants.MIN_X_POSITION <= value && value <= Constants.MAX_X_POSITION) {
                    x = value;
                } else {
                    throw new Exception("Invalid X value in cell");
                }
            } 
        }
        public int Y { 
            get => y; 
            set {
                if(Constants.MIN_Y_POSITION <= value && value <= Constants.MAX_Y_POSITION) {
                    y = value;
                } else {
                    throw new Exception("Invalid Y value in cell");
                }
            } 
        }
    
        private int x;
        private int y;
    }
}