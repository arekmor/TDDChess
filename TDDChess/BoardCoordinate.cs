namespace TDDChess
{
    public class BoardCoordinate
    {
        private readonly int _x;

        public int X
        {
            get { return _x; }        
        }

        private readonly int _y;

        public int Y
        {
            get { return _y; }
        }

        public BoardCoordinate(int x, int y )
        {
            _x = x;
            _y = y;
        }
        public bool IsCoordinateValidForBoard(int boardSize)
        {
            return IsDimensionValidForBoard(X, boardSize) && IsDimensionValidForBoard(Y, boardSize);
        }

        private static bool IsDimensionValidForBoard(int dimension, int boardSize)
        {
            return dimension > 0 && dimension <= boardSize;
        }
    }
}
