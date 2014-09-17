using System.Collections.Generic;

namespace TDDChess
{
    public class Pawn
    {
        public IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate coordinates)
        {
            yield return new BoardCoordinate(coordinates.X, coordinates.Y + 1);
        }
    }
}
