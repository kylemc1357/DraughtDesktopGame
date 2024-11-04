using NUnit.Framework;
using DraughtDesktopGame.Core.Models;

namespace DraughtDesktopGame.Tests.Models
{
    public class PlayerTests
    {
        [Test]
        public void Player_CreatedWithCorrectValues()
        {
            Player player = new Player("Player 1");
            Assert.That(player.Name, Is.EqualTo("Player 1"));
            Assert.That(player.GetPieces().Count, Is.EqualTo(0));
        }

        [Test]
        public void Player_AddPiece(){
            Player player = new Player("Player 1");
            Piece piece = new Piece(PieceType.Normal, PieceColor.Player1, 0, 0, player);
            player.AddPiece(piece);
            Assert.That(player.GetPieces().Count, Is.EqualTo(1));
            Assert.That(player.GetPieces()[0], Is.EqualTo(piece));
        }

        [Test]
        public void Player_RemovePiece(){
            Player player = new Player("Player 1");
            Piece piece = new Piece(PieceType.Normal, PieceColor.Player1, 0, 0, player);
            player.AddPiece(piece);
            Assert.That(player.GetPieces().Count, Is.EqualTo(1));
            player.RemovePiece(piece);
            Assert.That(player.GetPieces().Count, Is.EqualTo(0));
        }

        [Test]
        public void Player_GetPieces()
        {
            Player player = new Player("Player 1");
            Piece piece = new Piece(PieceType.Normal, PieceColor.Player1, 0, 0, player);
            player.AddPiece(piece);
            Assert.That(player.GetPieces().Count, Is.EqualTo(1));
            Assert.That(player.GetPieces()[0], Is.EqualTo(piece));
        }
    }
}