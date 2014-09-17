using System;

namespace TDDChess
{
    public class Board
    {
        private const int BoardSize = 8;
        private readonly Pawn[,] _pieces = new Pawn[BoardSize, BoardSize];
        public void AddPiece(Pawn piece, BoardCoordinate coordinates)
        {
            if (!coordinates.IsCoordinateValidForBoard(BoardSize))
                throw new ArgumentException();
            _pieces[coordinates.X, coordinates.Y] = piece;
        }        

        public Pawn GetPiece(BoardCoordinate coordinates)
        {
            return _pieces[coordinates.X, coordinates.Y];
        }
    }
}
