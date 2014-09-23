using System.Collections.Generic;
using System.Linq;

namespace TDDChess
{
    public class Bishop : Piece
    {
        public override IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate coordinates, int boardSize)
        {
            var spacesToRadiate = Enumerable.Range(1, boardSize);
            var allPossibleSpaces = spacesToRadiate.SelectMany(sp => GetDiagonalCoordinates(coordinates, sp));
            var validSpoaces = allPossibleSpaces.Where(bc => bc.IsCoordinateValidForBoard(boardSize));
            return validSpoaces;
        }
    }
}
