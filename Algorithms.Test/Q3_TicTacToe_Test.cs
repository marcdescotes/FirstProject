namespace Algorithms.Test;
using Algorithms;
using Algorithms.Q3_TicTacToe;

[TestClass]
public class Q3_TicTacToe_Test
{

    [TestMethod]
    public void TestXWins()
    {
        TicTacToe game = new TicTacToe();

        game.XPlay(0, 0);
        game.OPlay(1, 0);
        game.XPlay(0, 1);
        game.OPlay(1, 1);
        game.XPlay(0, 2);

        GameState gameState = game.GetGameState();

        Assert.AreEqual(GameState.XWins, gameState);
    }

    [TestMethod]
    public void TestXWinsDiagonal()
    {
        TicTacToe game = new TicTacToe();

        game.XPlay(0, 0);
        game.OPlay(0, 1);
        game.XPlay(1, 1);
        game.OPlay(1, 2);
        game.XPlay(2, 2);

        GameState gameState = game.GetGameState();

        Assert.AreEqual(GameState.XWins, gameState);
    }

    [TestMethod]
    public void TestOMissedTurn()
    {
        TicTacToe game = new TicTacToe();

        game.XPlay(0, 0);
        game.XPlay(1, 1);
        game.XPlay(2, 2);

        GameState gameState = game.GetGameState();

        Assert.AreEqual(GameState.Incomplete, gameState);
    }

    [TestMethod]
    public void TestOWins()
    {
        TicTacToe game = new TicTacToe();

        game.XPlay(0, 0);
        game.OPlay(1, 0);
        game.XPlay(0, 1);
        game.OPlay(1, 1);
        game.XPlay(2, 0);
        game.OPlay(1, 2);

        GameState gameState = game.GetGameState();

        Assert.AreEqual(GameState.OWins, gameState);
    }

    [TestMethod]
    public void TestDraw()
    {
        TicTacToe game = new TicTacToe();

        game.XPlay(0, 0);
        game.OPlay(1, 0);
        game.XPlay(0, 1);
        game.OPlay(1, 1);
        game.XPlay(2, 0);
        game.OPlay(2, 1);
        game.XPlay(1, 2);
        game.OPlay(0, 2);
        game.XPlay(2, 2);

        GameState gameState = game.GetGameState();

        Assert.AreEqual(GameState.Draw, gameState);
    }

    [TestMethod]
    public void TestIncomplete()
    {
        TicTacToe game = new TicTacToe();

        game.XPlay(0, 0);
        game.OPlay(1, 0);
        game.XPlay(0, 1);
        game.OPlay(1, 1);
        game.XPlay(2, 0);

        GameState gameState = game.GetGameState();

        Assert.AreEqual(GameState.Incomplete, gameState);
    }
}

