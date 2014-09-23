using System.Collections.Generic;
using System.Linq;

namespace TDDChess
{
    public class Rook : Piece
    {
        public override IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate coordinates, int boardSize)
        {
            var allCoordinates = Enumerable.Range(1, boardSize).ToList();
            var verticalCoordinates = allCoordinates.Where(y => y != coordinates.Y).Select(y => new BoardCoordinate(coordinates.X, y));
            var horizontalCoordinates = allCoordinates.Where(x => x != coordinates.X).Select(x => new BoardCoordinate(x, coordinates.X));
            return verticalCoordinates.Union(horizontalCoordinates);
        }
    }
}