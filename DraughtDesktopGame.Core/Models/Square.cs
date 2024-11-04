namespace DraughtDesktopGame.Core.Models
{
    public class Square
    {
        public int Row { get; }
        public int Col { get; }
        public bool IsBlack { get; }
        private Piece? OccupyingPiece { get; set; }

        public Square(int row, int col, bool isBlack)
        {
            Row = row;
            Col = col;
            IsBlack = isBlack;
            OccupyingPiece = null;
        }

        public Piece? GetOccupyingPiece() => OccupyingPiece;

        public void SetOccupyingPiece(Piece? piece) => OccupyingPiece = piece;
    }

}