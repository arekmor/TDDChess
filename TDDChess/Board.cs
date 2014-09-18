using System;

namespace TDDChess
{
    public class Board
    {
        private const int BoardSize = 8;
        private readonly Piece[,] _pieces = new Piece[BoardSize, BoardSize];
        public void AddPiece(Piece piece, BoardCoordinate coordinates)
        {
            if (!coordinates.IsCoordinateValidForBoard(BoardSize))
                throw new ArgumentException();
            _pieces[coordinates.X, coordinates.Y] = piece;
        }        

        public Piece GetPiece(BoardCoordinate coordinates)
        {
            return _pieces[coordinates.X, coordinates.Y];
        }
    }
}
