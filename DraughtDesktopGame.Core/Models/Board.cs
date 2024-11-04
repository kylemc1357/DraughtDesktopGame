namespace DraughtDesktopGame.Core.Models
{
    public class Board
    {
        public Square[,] Squares { get; }
        public Player[] Players { get; }
        private int CurrentPlayerIndex { get; set;} 

        public Board()
        {
            Squares = new Square[8, 8];
            Players =
            [
                new Player("Player 1"),
                new Player("Player 2")
            ];
            CurrentPlayerIndex = 0;
            InitializeBoard();
            PlaceInitialPieces();
        }

        public void InitializeBoard()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    bool isBlack = (row + col) % 2 == 1;
                    Squares[row, col] = new Square(row, col, isBlack);
                }
            }
        }

        public void PlaceInitialPieces()
        {
            for (int player = 0; player < 2; player++)
            {
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 8; col++)
                    {
                        if (player == 0){   //place pieces for player 1 - in bottom 3 rows
                            if (Squares[row, col].IsBlack)
                            {
                                GeneratePiece(row, col, 0);
                            }
                        }
                        else 
                        {    //place pieces for player 2 in top 3 rows
                            int adjRow = row + 5;
                            if ((adjRow + col) % 2 != 0){
                                GeneratePiece(adjRow, col, 1);
                            }
                        }
                    }
                }
            }
        }

        public void GeneratePiece(int row, int col, int playerIndex)
        {
            PieceColor colour = (PieceColor)playerIndex;  //get index for colour and player
            Piece piece = new Piece(PieceType.Normal, colour, row, col, Players[playerIndex]);
            Squares[row, col].SetOccupyingPiece(piece);  //set piece to square and add to players inventory
            Players[playerIndex].AddPiece(piece);
        }

        public void SwitchPlayer()
        {
            CurrentPlayerIndex = (CurrentPlayerIndex + 1) % 2;
        }

        public Player GetCurrentPlayer() => Players[CurrentPlayerIndex];
    }
}