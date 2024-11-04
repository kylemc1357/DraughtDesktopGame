using NUnit.Framework;
using DraughtDesktopGame.Core.Models;

namespace DraughtDesktopGame.Tests.Models
{
    public class SquareTests
    {
    
        [Test]
        public void Square_CreatesWithCorrectValues()
        {
            Square square = new Square(3, 2, true);
            
            Assert.That(square.Row, Is.EqualTo(3));
            Assert.That(square.Col, Is.EqualTo(2));
            Assert.That(square.IsBlack, Is.EqualTo(true));
        }

        [Test]
        public void Square_SetOccupyingPiece()
        {
            Square square = new Square(3, 2, true);
            Piece piece = new Piece(PieceType.Normal, PieceColor.Player1, 3, 2, new Player("Player1"));
            square.SetOccupyingPiece(piece);
            Assert.That(square.GetOccupyingPiece(), Is.EqualTo(piece));
        }
    }
}