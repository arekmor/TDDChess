using System.Collections.Generic;

namespace TDDChess
{
    public abstract class Piece
    {
        public abstract IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate coordinates, int boardSize);

        protected static IEnumerable<BoardCoordinate> GetDiagonalCoordinates(BoardCoordinate startPosition, int distance)
        {
            yield return new BoardCoordinate(startPosition.X + distance, startPosition.Y + distance);
            yield return new BoardCoordinate(startPosition.X + distance, startPosition.Y - distance);
            yield return new BoardCoordinate(startPosition.X - distance, startPosition.Y - distance);
            yield return new BoardCoordinate(startPosition.X - distance, startPosition.Y + distance);
        }

        protected static IEnumerable<BoardCoordinate> GetRadialAdjacentFrom(BoardCoordinate startPosition, int distance)
        {
            yield return new BoardCoordinate(startPosition.X, startPosition.Y + distance);
            yield return new BoardCoordinate(startPosition.X, startPosition.Y - distance);
            yield return new BoardCoordinate(startPosition.X + distance, startPosition.Y);
            yield return new BoardCoordinate(startPosition.X - distance, startPosition.Y);
        }
}
}