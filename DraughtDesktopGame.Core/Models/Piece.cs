namespace DraughtDesktopGame.Core.Models
{
    public class Piece
    {
        private PieceType type;
        private int row;
        private int column;
        private bool isKing;
        public PieceColor Colour { get; private set; }
        public Player BelongsTo { get; }

        public Piece(PieceType type, PieceColor color, int row, int column, Player player)
        {
            this.type = type;
            Colour = color;
            this.row = row;
            this.column = column;
            isKing = false;
            BelongsTo = player;
        }

        public PieceType GetPieceType() => type;

        public int GetRow() => row;
        public int GetColumn() => column;

        public bool IsKing() => isKing;

        public void MoveTo(int newRow, int newColumn)
        {
            row = newRow;
            column = newColumn;
        }

        public void MakeKing() => isKing = true;
    }
}