using NUnit.Framework;
using DraughtDesktopGame.Core.Models;

namespace DraughtDesktopGame.Tests.Models
{
    public class BoardTests
    {
        [Test]
        public void Board_WhenCreatedHasCorrectDimensions()
        {
            Board board = new Board();
            Assert.That(board.Squares.GetLength(0), Is.EqualTo(8));
            Assert.That(board.Squares.GetLength(1), Is.EqualTo(8));
        }

        [Test]
        public void Board_WhenCreatedHasTwoPlayers()
        {
            Board board = new Board();
            Assert.That(board.Players.Length, Is.EqualTo(2));
            Assert.That(board.Players[0].Name, Is.EqualTo("Player 1"));
            Assert.That(board.Players[1].Name, Is.EqualTo("Player 2"));
        }

        [Test]
        public void Board_InitalizesPiecesCorrectly()
        {
            //just picking random squares to check if they have pieces
            Board board = new Board();
            Assert.That(board.Squares[0, 1].GetOccupyingPiece, Is.Not.Null);
            Assert.That(board.Squares[0, 1].GetOccupyingPiece().BelongsTo, Is.EqualTo(board.Players[0]));

            Assert.That(board.Squares[6, 3].GetOccupyingPiece, Is.Not.Null);
            Assert.That(board.Squares[6, 3].GetOccupyingPiece().BelongsTo, Is.EqualTo(board.Players[1]));

            Assert.That(board.Squares[7, 6].GetOccupyingPiece, Is.Not.Null);
            Assert.That(board.Squares[7, 6].GetOccupyingPiece().BelongsTo, Is.EqualTo(board.Players[1]));

            Assert.That(board.Squares[5, 6].GetOccupyingPiece, Is.Not.Null);
            Assert.That(board.Squares[5, 6].GetOccupyingPiece().BelongsTo, Is.EqualTo(board.Players[1]));

            Assert.That(board.Squares[6, 7].GetOccupyingPiece, Is.Not.Null);
            Assert.That(board.Squares[6, 7].GetOccupyingPiece().BelongsTo, Is.EqualTo(board.Players[1]));

            Assert.That(board.Squares[1, 3].GetOccupyingPiece, Is.Null);
            Assert.That(board.Squares[4, 7].GetOccupyingPiece, Is.Null);
        }

        [Test]
        public void Board_TestPlayersAndIndex(){
            Board board = new Board();
            Assert.That(board.Players[0].Name, Is.EqualTo("Player 1"));
            Assert.That(board.Players[1].Name, Is.EqualTo("Player 2"));
            Assert.That(board.GetCurrentPlayer, Is.EqualTo(board.Players[0]));
            board.SwitchPlayer();
            Assert.That(board.GetCurrentPlayer, Is.EqualTo(board.Players[1]));
        }
    }
}