using NUnit.Framework;
using DraughtDesktopGame.Core.Models;

namespace DraughtDesktopGame.Tests.Models
{
    public class PieceTests
    {
        [Test]
        public void Piece_CreatedWithCorrectValues(){
            Piece piece = new Piece(PieceType.Normal, PieceColor.Player1, 4, 6, new Player("Player 1"));
            Assert.That(piece.GetPieceType(), Is.EqualTo(PieceType.Normal));
            Assert.That(piece.Colour, Is.EqualTo(PieceColor.Player1));
            Assert.That(piece.GetRow(), Is.EqualTo(4));
            Assert.That(piece.GetColumn(), Is.EqualTo(6));
            Assert.That(piece.IsKing(), Is.False);
            Assert.That(piece.BelongsTo.Name, Is.EqualTo("Player 1"));
        }

        [Test]
        public void Piece_TestMakeKing()
        {
            Piece piece = new Piece(PieceType.Normal, PieceColor.Player1, 0, 0, new Player("Player 1"));
            Assert.That(piece.IsKing(), Is.False);
            piece.MakeKing();
            Assert.That(piece.IsKing(), Is.True);
        }

        [Test]
        public void Piece_TestMoveTo(){
            Piece piece = new Piece(PieceType.Normal, PieceColor.Player1, 0, 0, new Player("Player 1"));
            Assert.That(piece.GetRow(), Is.EqualTo(0));
            Assert.That(piece.GetColumn(), Is.EqualTo(0));
            piece.MoveTo(1, 1);
            Assert.That(piece.GetRow(), Is.EqualTo(1));
            Assert.That(piece.GetColumn(), Is.EqualTo(1));
        }
    }
}