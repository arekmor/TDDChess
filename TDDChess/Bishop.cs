using System.Collections.Generic;

namespace TDDChess
{
    public class Bishop : Piece
    {
        public override IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate coordinates, int boardSize)
        {
            var moves = new List<BoardCoordinate>();
            for (int i = 1; i <= boardSize; i++)
            {
                var upAndRight = new BoardCoordinate(coordinates.X + i, coordinates.Y + i);
                if (upAndRight.IsCoordinateValidForBoard(boardSize))
                    moves.Add(upAndRight);

                var upAndLeft = new BoardCoordinate(coordinates.X - i, coordinates.Y + i);
                if (upAndLeft.IsCoordinateValidForBoard(boardSize))
                    moves.Add(upAndLeft);

                var downAndRight = new BoardCoordinate(coordinates.X + i, coordinates.Y - i);
                if (downAndRight.IsCoordinateValidForBoard(boardSize))
                    moves.Add(downAndRight);

                var downAndLeft = new BoardCoordinate(coordinates.X - i, coordinates.Y - i);
                if (downAndLeft.IsCoordinateValidForBoard(boardSize))
                    moves.Add(downAndLeft);
            }
            return moves;            
        }
    }
}
