using System.Collections.Generic;

namespace TDDChess
{
    public class Pawn
    {
        public IEnumerable<BoardCoordinates> GetMovesFrom(BoardCoordinates coordinates)
        {
            yield return new BoardCoordinates(coordinates.X, coordinates.Y + 1);
        }
    }
}
