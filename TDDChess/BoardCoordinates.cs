namespace TDDChess
{
    public class BoardCoordinates
    {
        private int _x;

        public int X
        {
            get { return _x; }        
        }

        private int _y;

        public int Y
        {
            get { return _y; }
        }

        public BoardCoordinates(int x, int y )
        {
            _x = x;
            _y = y;
        }

        public override bool Equals(object obj)
        {
            var coordinates = obj as BoardCoordinates;
            if (coordinates != null)
                return X + 10*Y == coordinates.X + 10*coordinates.Y;      
            return false;
        }

        public override int GetHashCode()
        {
            return X + 10*Y;
        }
    }
}
