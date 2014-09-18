using System.Collections.Generic;

namespace TDDChess
{
    public abstract class Piece
    {
        public abstract IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate coordinates);
    }
}