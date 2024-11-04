using DraughtDesktopGame.Core.Models;
namespace DraughtDesktopGame.Tests;

public class CheckIncludeWorks
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void BasicTest()
    {
        var board = new Board();
        Assert.That(board.Squares.GetLength(0), Is.EqualTo(8));
        Assert.That(board.Squares.GetLength(1), Is.EqualTo(8));
        Assert.That(board.Players.Length, Is.EqualTo(2));
        Assert.That(board.Players[0].Name, Is.EqualTo("Player 1"));
        Assert.That(board.Players[1].Name, Is.EqualTo("Player 2"));
        Assert.That(board.GetCurrentPlayer, Is.EqualTo(board.Players[0]));
        
    }
}