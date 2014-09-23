using System.Collections.Generic;
using System.Linq;

namespace TDDChess
{
    public class King : Piece
    {
        public override IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate coordinates, int boardSize)
        {
            var oneSquareAwayMoves = GetDiagonalCoordinates(coordinates, 1).Union(GetRadialAdjacentFrom(coordinates, 1));
            return oneSquareAwayMoves.Where(bc => bc.IsCoordinateValidForBoard(boardSize));
        }
    }
}
