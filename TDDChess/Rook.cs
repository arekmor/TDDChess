using System.Collections.Generic;
using System.Linq;

namespace TDDChess
{
    public class Rook : Piece
    {
        public override IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate coordinates)
        {
            return Enumerable.Empty<BoardCoordinate>();
        }
    }
}