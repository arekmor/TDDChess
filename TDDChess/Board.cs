namespace TDDChess
{
    public class Board
    {
        private const int BoardSize = 8;
        private readonly Pawn[,] _pieces = new Pawn[BoardSize, BoardSize];
        public void AddPiece(Pawn piece, BoardCoordinates coordinates)
        {
            _pieces[coordinates.X, coordinates.Y] = piece;
        }

        public Pawn GetPiece(BoardCoordinates coordinates)
        {
            return _pieces[coordinates.X, coordinates.Y];
        }
    }
}
