namespace DraughtDesktopGame.Core.Models

{
    public class Player
    {
        public string Name { get; }
        private List<Piece> pieces;

        public Player(string name)
        {
            Name = name;
            pieces = new List<Piece>();
        }

        public IReadOnlyList<Piece> GetPieces() => pieces.AsReadOnly();

        public void AddPiece(Piece piece) => pieces.Add(piece);

        public void RemovePiece(Piece piece) => pieces.Remove(piece);
    }
}