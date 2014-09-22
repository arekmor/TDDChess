using System.Collections.Generic;

namespace TDDChess
{
    public class Rook : Piece
    {
        public override IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate coordinates, int boardSize)
        {
            for (int i = 1; i <= boardSize; i++)
            {
                if (i != coordinates.Y)
                    yield return new BoardCoordinate(coordinates.X, i);
                if (i != coordinates.X)
                    yield return new BoardCoordinate(i, coordinates.Y);
            }
        }
    }
}