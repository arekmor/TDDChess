using System.Collections.Generic;

namespace TDDChess
{
    public class Pawn : Piece
    {
        public bool HasMoved { get; set; }
        public override IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate coordinates, int boardSize)
        {
            yield return new BoardCoordinate(coordinates.X, coordinates.Y + 1);
            if (!HasMoved)
                yield return new BoardCoordinate(coordinates.X, coordinates.Y + 2);
        }
        
    }
}